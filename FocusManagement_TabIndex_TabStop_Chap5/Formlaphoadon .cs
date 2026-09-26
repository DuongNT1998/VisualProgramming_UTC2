using System.Globalization;

namespace FocusManagement_TabIndex_TabStop
{
    public partial class Form1 : Form
    {
        // Danh mục sản phẩm mẫu (mô phỏng bảng SanPham trong CSDL thật)
        private static readonly Dictionary<string, (string Ten, decimal Gia)> DanhMucSanPham =
            new Dictionary<string, (string Ten, decimal Gia)>(StringComparer.OrdinalIgnoreCase)
        {
            { "SP001", ("Nồi cơm điện Sunhouse",     850000m) },
            { "SP002", ("Quạt điện Asia",            450000m) },
            { "SP003", ("Bàn ủi hơi nước Philips",   320000m) },
            { "SP004", ("Ấm siêu tốc Panasonic",     280000m) },
        };
        private decimal tongTien = 0m;
        public Form1()
        {
            InitializeComponent();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt && txt.TabStop)
                {
                    txt.KeyPress += TextBox_EnterMovesNext;
                }
            }
        }
        private void TextBox_EnterMovesNext(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // chặn tiếng "beep" và không cho nhập ký tự Enter vào ô
                SelectNextControl(
                    (Control)sender,
                    forward: true,
                    tabStopOnly: true,
                    nested: true,
                    wrap: true); // wrap = true: hết vòng thì quay lại control đầu tiên
            }
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                tb.BackColor = Color.LightYellow;
                tb.SelectAll();
            }

            string tenControl = (sender as Control)?.Name ?? "?";
            lblActiveControl.Text =
                $"Đang nhập tại: {tenControl}   |   Form.ActiveControl = {this.ActiveControl?.Name}";
        }
        private void txtMaSP_Leave(object sender, EventArgs e)
        {
            txtMaSP.BackColor = Color.White; // tắt highlight

            string ma = txtMaSP.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(ma))
            {
                txtTenSP.Clear();
                txtDonGia.Clear();
                txtThanhTien.Clear();
                errorProvider1.SetError(txtMaSP, "");
                return;
            }

            if (DanhMucSanPham.TryGetValue(ma, out var sp))
            {
                txtTenSP.Text = sp.Ten;
                txtDonGia.Text = sp.Gia.ToString("N0", CultureInfo.InvariantCulture);
                errorProvider1.SetError(txtMaSP, "");
            }
            else
            {
                txtTenSP.Clear();
                txtDonGia.Clear();
                errorProvider1.SetError(txtMaSP, "Không tìm thấy mã sản phẩm trong danh mục");
            }

            CapNhatThanhTien();
        }
        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            txtSoLuong.BackColor = Color.White;

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                txtSoLuong.Text = "1";
            }

            CapNhatThanhTien();
        }
        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            txtDonGia.BackColor = Color.White;

            bool hopLe = decimal.TryParse(
                txtDonGia.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal gia);

            txtDonGia.Text = (hopLe && gia >= 0)
                ? gia.ToString("N0", CultureInfo.InvariantCulture)
                : "0";

            CapNhatThanhTien();
        }

        private void CapNhatThanhTien()
        {
            int.TryParse(txtSoLuong.Text.Trim(), out int soLuong);
            decimal.TryParse(txtDonGia.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal donGia);

            decimal thanhTien = soLuong * donGia;
            txtThanhTien.Text = thanhTien.ToString("N0", CultureInfo.InvariantCulture);
        }
        private void btnThemDong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sản phẩm hợp lệ trước khi thêm vào hóa đơn.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Dùng Focus() để CHỦ ĐỘNG đưa con trỏ về đúng ô cần sửa bằng code
                txtMaSP.Focus();
                return;
            }

            int soLuong = int.TryParse(txtSoLuong.Text.Trim(), out int sl) ? sl : 1;
            decimal.TryParse(txtDonGia.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal donGia);
            decimal thanhTien = soLuong * donGia;

            string dong = $"{txtTenSP.Text,-28} x{soLuong,-4} = {thanhTien,15:N0} đ";
            lstHoaDon.Items.Add(dong);

            tongTien += thanhTien;
            lblTongTien.Text = $"Tổng cộng: {tongTien:N0} VNĐ";

            // Xóa trắng các ô nhập để chuẩn bị quét/nhập sản phẩm tiếp theo
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSoLuong.Text = "1";
            txtDonGia.Clear();
            txtThanhTien.Clear();
            errorProvider1.Clear();

            // Chủ động trả focus về ô Mã sản phẩm — đúng UX quầy thu ngân
            // thực tế (giống máy quét mã vạch luôn sẵn sàng cho lần quét kế tiếp)
            txtMaSP.Focus();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (lstHoaDon.Items.Count == 0)
            {
                MessageBox.Show(
                    "Hóa đơn chưa có sản phẩm nào.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(
                $"Thanh toán thành công!\nTổng tiền: {tongTien:N0} VNĐ",
                "Hoàn tất",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            lstHoaDon.Items.Clear();
            tongTien = 0m;
            lblTongTien.Text = "Tổng cộng: 0 VNĐ";
            txtMaSP.Focus();
        }
    }
}
