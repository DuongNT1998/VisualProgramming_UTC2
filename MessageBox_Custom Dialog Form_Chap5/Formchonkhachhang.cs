namespace MessageBox_Custom_Dialog_Form
{
    public partial class Formchonkhachhang : Form
    {
        public string MaKH { get; private set; }
        public string TenKH { get; private set; }

        private static readonly List<KhachHang> DanhSachKhachHangMau = new List<KhachHang>
        {
            new KhachHang { MaKH = "KH001", TenKH = "Nguyễn Văn An",   SDT = "0901111111" },
            new KhachHang { MaKH = "KH002", TenKH = "Trần Thị Bình",   SDT = "0902222222" },
            new KhachHang { MaKH = "KH003", TenKH = "Lê Hoàng Cường",  SDT = "0903333333" },
            new KhachHang { MaKH = "KH004", TenKH = "Phạm Thị Duyên",  SDT = "0904444444" },
            new KhachHang { MaKH = "KH005", TenKH = "Hoàng Văn Em",    SDT = "0905555555" },
        };
        public Formchonkhachhang(string tuKhoaMacDinh = "")
        {
            InitializeComponent();
            txtTimKiem.Text = tuKhoaMacDinh;
            NapDuLieu(tuKhoaMacDinh);
        }
        private void NapDuLieu(string tuKhoa)
        {
            List<KhachHang> ketQua = string.IsNullOrWhiteSpace(tuKhoa)
                ? DanhSachKhachHangMau
                : DanhSachKhachHangMau
                    .Where(kh => kh.TenKH.ToLower().Contains(tuKhoa.Trim().ToLower()))
                    .ToList();

            // Gán lại null rồi gán data mới — cách an toàn để "refresh" binding
            // của DataGridView khi nguồn dữ liệu thay đổi (đã học ở Chương 3)
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = ketQua;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            NapDuLieu(txtTimKiem.Text);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn một khách hàng trong danh sách.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var kh = (KhachHang)dgvKhachHang.SelectedRows[0].DataBoundItem;
            MaKH = kh.MaKH;
            TenKH = kh.TenKH;

            // QUAN TRỌNG: gán DialogResult khi Form đang được mở bằng ShowDialog()
            // sẽ TỰ ĐỘNG đóng Form lại — không cần gọi this.Close()
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
