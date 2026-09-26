namespace DemoBasicWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhapThongTin_Click(object sender, EventArgs e)
        {

            string mssv = tbMSSV.Text;
            string hoTen = tbHoTen.Text;
            string lop = cbLop.SelectedItem?.ToString() ?? "Chưa chọn";
            string gioiTinh = rdGTNam.Checked ? "Nam" : (rdGTNu.Checked ? "Nữ" : "Chưa chọn");
            string ngaySinh = dtNgaySinh.Value.ToString("dd/MM/yyyy");
            string ghiChu = tbGhiChu.Text;

            // Lấy danh sách năng khiếu đã chọn
            List<string> nangKhieuList = new List<string>();
            foreach (var item in clbNangKhieu.CheckedItems)
            {
                nangKhieuList.Add(item.ToString());
            }
            string nangKhieu = nangKhieuList.Count > 0 ? string.Join(", ", nangKhieuList) : "Không có";

            // Hiển thị thông tin trên Label trong Panel
            lbKetQua.Text = $"MSSV: {mssv}\n" +
                             $"Họ và Tên: {hoTen}\n" +
                             $"Lớp: {lop}\n" +
                             $"Giới Tính: {gioiTinh}\n" +
                             $"Ngày Sinh: {ngaySinh}\n" +
                             $"Năng Khiếu: {nangKhieu}\n" +
                             $"Ghi Chú: {ghiChu}";
        }
    }
}
