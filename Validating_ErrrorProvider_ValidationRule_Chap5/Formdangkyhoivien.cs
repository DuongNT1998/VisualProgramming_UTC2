using System.ComponentModel;
using System.Globalization;

namespace Validating_ErrrorProvider_ValidationRule
{
    public partial class Formdangkyhoivien : Form
    {
        public Formdangkyhoivien()
        {
            InitializeComponent();
            // Sinh mã hội viên tự động (mô phỏng — thực tế sẽ lấy từ CSDL)
            txtMaHV.Text = "HV" + DateTime.Now.ToString("yyMMddHHmmss");
        }
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true; // chặn focus rời khỏi field này
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập họ và tên");
            }
            else
            {
                errorProvider1.SetError(txtHoTen, ""); // rỗng = xóa lỗi
            }
        }

        private void txtNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            string text = txtNgaySinh.Text.Trim();

            // Rule: đúng định dạng ngày dd/MM/yyyy
            bool dungDinhDang = DateTime.TryParseExact(
                text, "dd/MM/yyyy", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime ngaySinh);

            if (!dungDinhDang)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgaySinh, "Nhập ngày theo định dạng dd/MM/yyyy");
                return;
            }

            // Rule: tuổi phải nằm trong khoảng 18-60 (điều kiện cấp thẻ tín dụng nội bộ)
            int tuoi = TinhTuoi(ngaySinh);
            if (tuoi < 18 || tuoi > 60)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgaySinh, $"Tuổi phải từ 18-60 để đăng ký (hiện tại: {tuoi})");
                return;
            }

            errorProvider1.SetError(txtNgaySinh, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Email không được để trống");
            }
            // Kiểm tra đơn giản theo đúng slide (thực tế nên dùng Regex/MailAddress)
            else if (!email.Contains("@") || !email.Contains("."))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Email không đúng định dạng");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            string sdt = txtSDT.Text.Trim();

            // Rule: đúng 10 chữ số, toàn số, bắt đầu bằng 0
            if (sdt.Length != 10 || !sdt.All(char.IsDigit) || !sdt.StartsWith("0"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSDT, "SĐT phải có 10 chữ số, bắt đầu bằng 0");
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }
        }

        private void txtHanMucTinDung_Validating(object sender, CancelEventArgs e)
        {
            // Dùng InvariantCulture để chấp nhận "1500000" hoặc "1500000.5"
            bool parseDuoc = decimal.TryParse(
                txtHanMucTinDung.Text,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out decimal hanMuc);

            if (!parseDuoc || hanMuc < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHanMucTinDung, "Hạn mức phải là một số không âm");
            }
            else
            {
                errorProvider1.SetError(txtHanMucTinDung, "");
            }
        }

        private void cboTinhThanh_Validating(object sender, CancelEventArgs e)
        {
            // SelectedIndex = 0 tương ứng dòng "-- Chọn tỉnh/thành --"
            if (cboTinhThanh.SelectedIndex <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cboTinhThanh, "Vui lòng chọn tỉnh/thành phố");
            }
            else
            {
                errorProvider1.SetError(cboTinhThanh, "");
            }
        }

        private void txt_Validated(object sender, EventArgs e)
        {
            if (sender is Control ctrl)
            {
                ctrl.BackColor = Color.LightGreen;
            }
        }
        private bool KiemTraHopLe()
        {
            return this.ValidateChildren();
        }

        private int TinhTuoi(DateTime ngaySinh)
        {
            int tuoi = DateTime.Today.Year - ngaySinh.Year;
            if (ngaySinh.Date > DateTime.Today.AddYears(-tuoi))
            {
                tuoi--;
            }
            return tuoi;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lưu ý: vì AutoValidate = EnablePreventFocusChange, nếu control
            // ĐANG được focus bị lỗi thì focus sẽ bị giữ lại tại đó và sự kiện
            // Click này thậm chí sẽ KHÔNG được gọi (đây là hành vi chuẩn của
            // WinForms — không phải lỗi). ValidateChildren() bên dưới xử lý
            // phần còn lại: các field khác chưa được người dùng "ghé qua".
            if (!KiemTraHopLe())
            {
                MessageBox.Show(
                    "Vui lòng kiểm tra lại các trường đang báo lỗi (icon đỏ nhấp nháy).",
                    "Dữ liệu chưa hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Trong thực tế: gọi tầng Service/Repository (EF Core) để lưu vào CSDL
            decimal hanMuc = decimal.Parse(txtHanMucTinDung.Text, CultureInfo.InvariantCulture);

            string thongTin =
                $"Mã hội viên: {txtMaHV.Text}\n" +
                $"Họ tên: {txtHoTen.Text}\n" +
                $"Ngày sinh: {txtNgaySinh.Text}\n" +
                $"Email: {txtEmail.Text}\n" +
                $"SĐT: {txtSDT.Text}\n" +
                $"Hạn mức tín dụng: {hanMuc:N0} VNĐ\n" +
                $"Tỉnh/Thành: {cboTinhThanh.Text}";

            MessageBox.Show(
                "Đăng ký hội viên thành công!\n\n" + thongTin,
                "Thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // btnHuy.CausesValidation = false (đặt trong Designer) nên bấm nút này
            // KHÔNG kích hoạt Validating của field đang dở dang → người dùng luôn
            // thoát/làm mới được form dù đang nhập sai ở đâu đó.
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn hủy và làm mới toàn bộ thông tin đã nhập?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                LamMoiForm();
            }
        }

        private void LamMoiForm()
        {
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtHanMucTinDung.Text = "0";
            cboTinhThanh.SelectedIndex = 0;
            txtMaHV.Text = "HV" + DateTime.Now.ToString("yyMMddHHmmss");

            errorProvider1.Clear();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox)
                {
                    ctrl.BackColor = SystemColors.Window;
                }
            }

            txtHoTen.Focus();
        }

    }
}
