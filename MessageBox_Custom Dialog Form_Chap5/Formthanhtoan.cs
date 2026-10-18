using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MessageBox_Custom_Dialog_Form
{
    public partial class Formthanhtoan : Form
    {
        private readonly List<(string Ten, int SoLuong, decimal DonGia)> hoaDonMau =
          new List<(string Ten, int SoLuong, decimal DonGia)>
      {
            ("Nồi cơm điện Sunhouse",   2, 850000m),
            ("Bàn ủi hơi nước Philips", 1, 320000m),
            ("Ấm siêu tốc Panasonic",   1, 280000m),
      };

        private decimal tongTien = 0m;

        // Thông tin khách hàng đã chọn (nhận về từ Custom Dialog Form)
        private string maKHDaChon = null;
        private string tenKHDaChon = null;
        public Formthanhtoan()
        {
            InitializeComponent();
            NapHoaDonMau();
        }
        private void NapHoaDonMau()
        {
            lstHoaDon.Items.Clear();
            tongTien = 0m;

            foreach (var dong in hoaDonMau)
            {
                decimal thanhTien = dong.SoLuong * dong.DonGia;
                tongTien += thanhTien;
                lstHoaDon.Items.Add($"{dong.Ten,-28} x{dong.SoLuong,-4} = {thanhTien,15:N0} đ");
            }

            lblTongTien.Text = $"Tổng cộng: {tongTien:N0} VNĐ";
        }

        private void btnChonKhachHang_Click(object sender, EventArgs e)
        {
            // "using" đảm bảo dialog được Dispose() ngay sau khi đóng — tránh rò rỉ bộ nhớ
            using (var dlg = new Formchonkhachhang())
            {
                // ShowDialog() CHẶN code tại đây cho đến khi dialog đóng lại
                // (khác với Show() sẽ chạy song song, không chờ)
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    maKHDaChon = dlg.MaKH;
                    tenKHDaChon = dlg.TenKH;
                    txtKhachHangDaChon.Text = $"{dlg.MaKH} - {dlg.TenKH}";
                }
                // Nếu bấm Hủy (DialogResult.Cancel) → không làm gì, giữ nguyên lựa chọn cũ
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // ----- Loại 1: WARNING — cảnh báo thiếu thông tin, có thể tiếp tục sửa -----
            if (string.IsNullOrEmpty(maKHDaChon))
            {
                MessageBox.Show(
                    "Vui lòng chọn khách hàng trước khi thanh toán.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // ----- Loại 2: QUESTION — hỏi xác nhận trước hành động quan trọng -----
            DialogResult xacNhan = MessageBox.Show(
                $"Xác nhận thanh toán hóa đơn trị giá {tongTien:N0} VNĐ " +
                $"cho khách hàng \"{tenKHDaChon}\"?",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (xacNhan != DialogResult.Yes)
            {
                return; // người dùng chọn No → dừng, không làm gì thêm
            }

            // ----- Loại 3: ERROR — lỗi nghiêm trọng, thao tác không thể hoàn tất -----
            // (chkMoPhongLoi chỉ phục vụ mục đích DEMO để chủ động bật lỗi khi giảng dạy;
            //  trong ứng dụng thật đây sẽ là kết quả try/catch khi gọi CSDL qua EF Core)
            if (chkMoPhongLoi.Checked)
            {
                MessageBox.Show(
                    "Không thể kết nối đến máy chủ cơ sở dữ liệu.\n" +
                    "Vui lòng kiểm tra kết nối mạng và thử lại.",
                    "Lỗi thanh toán",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // ----- Loại 4: INFORMATION — thông báo kết quả thành công -----
            MessageBox.Show(
                $"Thanh toán thành công!\n\n" +
                $"Khách hàng: {tenKHDaChon}\n" +
                $"Số tiền:    {tongTien:N0} VNĐ",
                "Hoàn tất",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LamMoiGiaoDich();
        }

        private void btnHuyGiaoDich_Click(object sender, EventArgs e)
        {
            // QUESTION lần 2 — minh họa việc dùng lại cùng 1 loại MessageBox
            // cho một tình huống nghiệp vụ khác (hủy thay vì xác nhận thanh toán)
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn hủy toàn bộ giao dịch này?",
                "Xác nhận hủy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Đã hủy giao dịch.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LamMoiGiaoDich();
            }
        }

        private void LamMoiGiaoDich()
        {
            maKHDaChon = null;
            tenKHDaChon = null;
            txtKhachHangDaChon.Text = "-- Chưa chọn khách hàng --";
            chkMoPhongLoi.Checked = false;
            NapHoaDonMau();
        }

    }
}
