using AppDeployment_Chap11.Helpers;
using Serilog;
using System.Diagnostics;

namespace AppDeployment_Chap11
{
    public partial class FormMain : Form
    {
        private readonly Button btnDanhMuc;
        private readonly Button btnSanPham;
        private readonly Label lblNgonNgu;
        private readonly ComboBox cboNgonNgu;
        private readonly Button btnGayLoi;
        private readonly Button btnMoLog;
        private readonly Label lblVersion;

        public FormMain()
        {
            Width = 460;
            Height = 420;
            StartPosition = FormStartPosition.CenterScreen;

            btnDanhMuc = new Button { Location = new Point(80, 40), Size = new Size(280, 40) };
            btnDanhMuc.Click += (s, e) => new FormDanhMucSanPham().ShowDialog();

            btnSanPham = new Button { Location = new Point(80, 95), Size = new Size(280, 40) };
            btnSanPham.Click += (s, e) => new FormSanPham().ShowDialog();

            lblNgonNgu = new Label { Location = new Point(80, 160), AutoSize = true };
            cboNgonNgu = new ComboBox
            {
                Location = new Point(190, 157),
                Width = 170,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboNgonNgu.Items.Add("Tiếng Việt (vi-VN)");
            cboNgonNgu.Items.Add("English (en-US)");
            cboNgonNgu.SelectedIndex = Strings.CurrentCulture == "en-US" ? 1 : 0;
            cboNgonNgu.SelectedIndexChanged += CboNgonNgu_SelectedIndexChanged;

            btnGayLoi = new Button
            {
                Location = new Point(80, 210),
                Size = new Size(280, 35),
                BackColor = Color.MistyRose
            };
            btnGayLoi.Click += (s, e) =>
            {
                object obj = null;
                obj.ToString();
            };

            btnMoLog = new Button { Location = new Point(80, 255), Size = new Size(280, 35) };
            btnMoLog.Click += (s, e) =>
            {
                string folder = LogHelper.LogDirectory;
                Directory.CreateDirectory(folder);
                Process.Start(new ProcessStartInfo("explorer.exe", $"\"{folder}\"") { UseShellExecute = true });
            };

            lblVersion = new Label
            {
                Location = new Point(80, 315),
                AutoSize = true,
                ForeColor = Color.Gray
            };

            Controls.Add(btnDanhMuc);
            Controls.Add(btnSanPham);
            Controls.Add(lblNgonNgu);
            Controls.Add(cboNgonNgu);
            Controls.Add(btnGayLoi);
            Controls.Add(btnMoLog);
            Controls.Add(lblVersion);

            ApplyLanguage();
        }

        private void CboNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string culture = cboNgonNgu.SelectedIndex == 1 ? "en-US" : "vi-VN";
            if (culture == Strings.CurrentCulture) return;

            Strings.SetCulture(culture);
            new UserSettings { Culture = culture }.Save();
            Log.Information("Người dùng đổi ngôn ngữ sang {Culture}", culture);

            ApplyLanguage();
        }

        private void ApplyLanguage()
        {
            Text = Strings.Get("AppTitle");
            btnDanhMuc.Text = Strings.Get("QuanLyDanhMuc");
            btnSanPham.Text = Strings.Get("QuanLySanPham");
            lblNgonNgu.Text = Strings.Get("NgonNgu");
            btnGayLoi.Text = Strings.Get("GayLoi");
            btnMoLog.Text = Strings.Get("MoLog");
            lblVersion.Text = Strings.Get("PhienBan") + " " +
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }
    }
}