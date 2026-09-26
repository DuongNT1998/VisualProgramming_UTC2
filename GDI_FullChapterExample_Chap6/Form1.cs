using System.Drawing.Drawing2D;
using System.Drawing;

using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GDI_FullChapterExample_Chap6
{
    /// <summary>Dữ liệu in lên thẻ.</summary>
    public record CardData(string Name, string Id, string Major);

    /// <summary>Panel bật DoubleBuffered để vẽ GDI+ không nhấp nháy.</summary>
    public class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }
    }
    public partial class Form1 : Form
    {
        // Kích thước thẻ CR80 (thẻ ATM / thẻ sinh viên): 85.6 x 54 mm = 3.37 x 2.125 inch.
        // Dùng đơn vị logic = 1/100 inch  =>  337 x 212. Hàm vẽ chỉ biết đơn vị logic này,
        // còn "thiết bị" (màn hình / bitmap / máy in) tự lo việc quy đổi ra điểm ảnh thật.
        private const int CardW = 337;
        private const int CardH = 212;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object? sender, EventArgs e)
        {
            cboMajor.Items.AddRange(new object[]
            {
                "Công nghệ thông tin",
                "Kỹ thuật phần mềm",
                "Hệ thống thông tin",
                "An toàn thông tin"
            });
            cboMajor.SelectedIndex = 0;

            Log("GDI+ = 3 nhóm dịch vụ. Trên thẻ:");
            Log(" • 2D Vector  : bo góc (GraphicsPath), gradient, mã vạch, hình tròn");
            Log(" • Imaging    : xuất Bitmap 3x qua Graphics.FromImage, lưu PNG");
            Log(" • Typography : DrawString, StringFormat, chữ xoay (watermark)");
            Log("Cùng 1 hàm DrawStudentCard() vẽ lên: Panel, Bitmap, Máy in.");
        }


        private void DataChanged(object? sender, EventArgs e)
        {
            lblRotate.Text = $"Xoay: {trkRotate.Value}°";
            lblZoom.Text = $"Phóng: {trkZoom.Value}%";
            pnlCard.Invalidate();   // yêu cầu Windows gửi WM_PAINT -> gọi lại pnlCard_Paint
        }



        private void pnlCard_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ApplyQuality(g, chkAntiAlias.Checked);

            // Scale sao cho thẻ xoay góc nào cũng lọt trong panel (dùng đường chéo)
            float diag = MathF.Sqrt(CardW * CardW + CardH * CardH);
            float scale = Math.Min(pnlCard.ClientSize.Width, pnlCard.ClientSize.Height)
                          / diag * (trkZoom.Value / 100f);

            GraphicsState state = g.Save();
            g.TranslateTransform(pnlCard.ClientSize.Width / 2f, pnlCard.ClientSize.Height / 2f);
            g.RotateTransform(trkRotate.Value);
            g.ScaleTransform(scale, scale);
            g.TranslateTransform(-CardW / 2f, -CardH / 2f);

            DrawStudentCard(g, GetData(), chkWatermark.Checked);

            g.Restore(state);
            lblDc.Text = DescribeGraphics(g, "Màn hình (Panel.Paint)", multiLine: true);
        }



        private void btnExport_Click(object? sender, EventArgs e)
        {
            const int k = 3;   // xuất độ phân giải gấp 3 lần
            var bmp = new Bitmap(CardW * k, CardH * k, PixelFormat.Format32bppArgb);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);      // 4 góc bo tròn sẽ trong suốt trong file PNG
                ApplyQuality(g, true);
                g.ScaleTransform(k, k);
                DrawStudentCard(g, GetData(), chkWatermark.Checked);
                Log(DescribeGraphics(g, $"Bitmap {bmp.Width}x{bmp.Height}px (FromImage)"));
            }

            pbExport.Image?.Dispose();
            pbExport.Image = bmp;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (pbExport.Image == null) return;
            using var dlg = new SaveFileDialog
            {
                Filter = "PNG image|*.png",
                FileName = $"TheSinhVien_{txtId.Text}.png"
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                pbExport.Image.Save(dlg.FileName, ImageFormat.Png);
                Log("Đã lưu: " + dlg.FileName);
            }
        }




        private void btnPreview_Click(object? sender, EventArgs e)
        {
            try
            {
                using var pd = new PrintDocument { DocumentName = "The sinh vien" };
                pd.PrintPage += Pd_PrintPage;
                using var dlg = new PrintPreviewDialog { Document = pd, Width = 900, Height = 700 };
                dlg.ShowDialog(this);
            }
            catch (InvalidPrinterException)
            {
                MessageBox.Show(this,
                    "Máy chưa cài máy in nào nên không thể xem trước. " +
                    "Hãy cài 1 máy in ảo (ví dụ: Microsoft Print to PDF) rồi thử lại.",
                    "Không có máy in", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics!;
            ApplyQuality(g, true);

            // Với máy in, PageUnit mặc định = 1/100 inch nên 337 x 212 đơn vị = ĐÚNG kích thước thẻ thật
            GraphicsState state = g.Save();
            g.TranslateTransform(e.MarginBounds.Left, e.MarginBounds.Top);
            DrawStudentCard(g, GetData(), chkWatermark.Checked);
            g.Restore(state);

            using var f = new Font("Segoe UI", 9f);
            g.DrawString("Bản in thử - kích thước thật 85,6 x 54 mm (thẻ CR80).\n" +
                         DescribeGraphics(g, "Máy in (PrintPage)", multiLine: true),
                         f, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + CardH + 20);

            Log(DescribeGraphics(g, "Máy in (PrintPage)"));
            e.HasMorePages = false;
        }


        private void btnStamp_Click(object? sender, EventArgs e)
        {
            using Graphics g = pnlCard.CreateGraphics();
            ApplyQuality(g, chkAntiAlias.Checked);

            const string text = "ĐÃ DUYỆT";
            using var font = new Font("Segoe UI", 30f, FontStyle.Bold, GraphicsUnit.Pixel);
            using var brush = new SolidBrush(Color.FromArgb(210, Color.Crimson));
            using var pen = new Pen(brush, 4f);
            SizeF sz = g.MeasureString(text, font);

            g.TranslateTransform(pnlCard.ClientSize.Width / 2f, pnlCard.ClientSize.Height / 2f);
            g.RotateTransform(-15);
            g.DrawRectangle(pen, -sz.Width / 2 - 10, -sz.Height / 2 - 4, sz.Width + 20, sz.Height + 8);
            g.DrawString(text, font, brush, -sz.Width / 2, -sz.Height / 2);

            Log("CreateGraphics: dấu vừa đóng sẽ MẤT khi panel vẽ lại (kéo thanh xoay để kiểm chứng).");
        }


        private static void DrawStudentCard(Graphics g, CardData d, bool watermark)
        {
            var card = new RectangleF(0.5f, 0.5f, CardW - 1.5f, CardH - 1.5f);   // toạ độ số thực
            using GraphicsPath cardPath = RoundedRect(card, 14f);

            // Nền thẻ: gradient chéo
            using (var bg = new LinearGradientBrush(card, Color.White,
                       Color.FromArgb(226, 236, 253), LinearGradientMode.ForwardDiagonal))
                g.FillPath(bg, cardPath);

            // Dải header, cắt (clip) theo góc bo tròn của thẻ
            GraphicsState st = g.Save();
            g.SetClip(cardPath, CombineMode.Intersect);
            var header = new RectangleF(0, 0, CardW, 56);
            using (var hb = new LinearGradientBrush(header, Color.FromArgb(13, 42, 92),
                       Color.FromArgb(37, 99, 235), LinearGradientMode.Horizontal))
                g.FillRectangle(hb, header);
            using (var glass = new SolidBrush(Color.FromArgb(45, Color.White)))   // Alpha Blending
            {
                g.FillEllipse(glass, 250, -40, 120, 120);
                g.FillEllipse(glass, 290, -10, 80, 80);
            }
            g.Restore(st);

            // Chữ header
            using (var f1 = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Pixel))
            using (var f2 = new Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel))
            using (var f3 = new Font("Segoe UI", 10f, FontStyle.Bold, GraphicsUnit.Pixel))
            {
                g.DrawString("TRƯỜNG ĐẠI HỌC CÔNG NGHỆ", f1, Brushes.White, 14, 8);
                g.DrawString("KHOA CÔNG NGHỆ THÔNG TIN", f2, Brushes.WhiteSmoke, 14, 25);
                g.DrawString("THẺ SINH VIÊN", f3, Brushes.Gold, 14, 38);
            }

            // Ảnh đại diện: hình tròn gradient + chữ cái đầu
            var avatar = new RectangleF(18, 72, 82, 82);
            using (var ab = new LinearGradientBrush(avatar, Color.FromArgb(96, 165, 250),
                       Color.FromArgb(30, 64, 175), 45f))
                g.FillEllipse(ab, avatar);
            using (var ring = new Pen(Color.White, 3f))
                g.DrawEllipse(ring, avatar);
            using (var fi = new Font("Segoe UI", 30f, FontStyle.Bold, GraphicsUnit.Pixel))
            using (var center = new StringFormat
            { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                g.DrawString(GetInitials(d.Name), fi, Brushes.White, avatar, center);

            // Thông tin văn bản (cắt "..." nếu quá dài)
            using (var lbl = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Pixel))
            using (var fName = new Font("Segoe UI", 16f, FontStyle.Bold, GraphicsUnit.Pixel))
            using (var fId = new Font("Consolas", 14f, FontStyle.Bold, GraphicsUnit.Pixel))
            using (var fMajor = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Pixel))
            using (var gray = new SolidBrush(Color.FromArgb(120, 130, 150)))
            using (var dark = new SolidBrush(Color.FromArgb(15, 30, 60)))
            using (var sf = new StringFormat
            { Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap })
            {
                g.DrawString("HỌ VÀ TÊN", lbl, gray, 116, 66);
                g.DrawString(d.Name, fName, dark, new RectangleF(116, 77, 207, 24), sf);
                g.DrawString("MÃ SỐ SINH VIÊN", lbl, gray, 116, 106);
                g.DrawString(d.Id, fId, dark, new RectangleF(116, 117, 207, 20), sf);
                g.DrawString("NGÀNH ĐÀO TẠO", lbl, gray, 116, 140);
                g.DrawString(d.Major, fMajor, dark, new RectangleF(116, 151, 207, 20), sf);
                g.DrawString("Có giá trị đến 09/2030", lbl, gray, 18, 166);
            }

            // Mã vạch giả lập sinh từ MSSV (2D vector: nhiều FillRectangle)
            float x = 116f;
            int i = 0;
            while (x < 322f)
            {
                char c = d.Id.Length > 0 ? d.Id[i % d.Id.Length] : '0';
                float w = 1 + (c + i * 7) % 3;
                if (i % 2 == 0) g.FillRectangle(Brushes.Black, x, 178, w, 22);
                x += w;
                i++;
            }

            // Watermark chữ xoay trong suốt
            if (watermark)
            {
                GraphicsState ws = g.Save();
                g.SetClip(cardPath, CombineMode.Intersect);
                g.TranslateTransform(CardW / 2f, CardH / 2f + 14);
                g.RotateTransform(-25);
                using var wf = new Font("Segoe UI", 54f, FontStyle.Bold, GraphicsUnit.Pixel);
                using var wb = new SolidBrush(Color.FromArgb(38, 37, 99, 235));
                using var center = new StringFormat
                { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString("SINH VIÊN", wf, wb, 0, 0, center);
                g.Restore(ws);
            }

            // Viền thẻ
            using var border = new Pen(Color.FromArgb(170, 195, 235), 1.5f);
            g.DrawPath(border, cardPath);
        }


        private CardData GetData() =>
          new(txtName.Text.Trim(), txtId.Text.Trim(), cboMajor.Text);

        private static void ApplyQuality(Graphics g, bool antiAlias)
        {
            g.SmoothingMode = antiAlias ? SmoothingMode.AntiAlias : SmoothingMode.None;
            g.PixelOffsetMode = antiAlias ? PixelOffsetMode.HighQuality : PixelOffsetMode.Default;
            g.TextRenderingHint = antiAlias
                ? System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
                : System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        private static GraphicsPath RoundedRect(RectangleF r, float radius)
        {
            float dd = radius * 2;
            var p = new GraphicsPath();
            p.AddArc(r.Left, r.Top, dd, dd, 180, 90);
            p.AddArc(r.Right - dd, r.Top, dd, dd, 270, 90);
            p.AddArc(r.Right - dd, r.Bottom - dd, dd, dd, 0, 90);
            p.AddArc(r.Left, r.Bottom - dd, dd, dd, 90, 90);
            p.CloseFigure();
            return p;
        }

        private static string GetInitials(string fullName)
        {
            string[] parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return "?";
            if (parts.Length == 1) return parts[0][..1].ToUpper();
            return (parts[0][..1] + parts[^1][..1]).ToUpper();
        }

        private static string DescribeGraphics(Graphics g, string device, bool multiLine = false)
        {
            string sep = multiLine ? "\n" : " | ";
            return $"Thiết bị: {device}{sep}" +
                   $"DpiX/DpiY = {g.DpiX:0}/{g.DpiY:0}{sep}" +
                   $"PageUnit = {g.PageUnit}{sep}" +
                   $"Smoothing = {g.SmoothingMode}, TextHint = {g.TextRenderingHint}";
        }

        private void Log(string message)
        {
            lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] {message}");
            lstLog.TopIndex = lstLog.Items.Count - 1;
        }

    }
}
