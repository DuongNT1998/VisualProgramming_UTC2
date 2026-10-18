using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLySanPham_EFCore_Chap8.Helpers;
using QuanLySanPham_EFCore_Chap8.Models;

namespace QuanLySanPham_EFCore_Chap8
{
    public partial class FormSanPham : Form
    {
        private int? _selectedId = null;
        private string _tempSelectedImagePath = null; // ảnh gốc người dùng vừa chọn, CHƯA copy vào thư mục app
        private string _currentImageFileName = null;  // tên file ảnh hiện tại đang lưu trong DB (khi sửa)

        public FormSanPham()
        {
            InitializeComponent();
            SetupDataGridViewColumns();   // ← thêm dòng này, đặt NGAY SAU InitializeComponent()

            picHinhAnh.Image = ImageHelper.CreatePlaceholder();
            _ = LoadDanhMucAsync();
            _ = LoadDataAsync();
        }


        // ===== Khai báo cột DataGridView bằng code — tránh bị VS Designer ghi đè =====
        private void SetupDataGridViewColumns()
        {
            if (dgv.Columns.Count > 0) return; // tránh add trùng nếu gọi lại

            dgv.AutoGenerateColumns = false;
            dgv.RowTemplate.Height = 60;

            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Idsp", HeaderText = "Mã SP", Width = 60 });
            dgv.Columns.Add(new DataGridViewImageColumn
            {
                Name = "HinhAnh",
                HeaderText = "Ảnh",
                Width = 70,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenSp", HeaderText = "Tên sản phẩm", Width = 200 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoLuong", HeaderText = "SL", Width = 60 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Dvt", HeaderText = "ĐVT", Width = 60 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "DonGia", HeaderText = "Đơn giá", Width = 100 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenDanhMuc", HeaderText = "Danh mục", Width = 180 });
        }

        // ===== NẠP DANH MỤC CHO COMBOBOX (dùng LINQ Query Syntax) =====
        private async System.Threading.Tasks.Task LoadDanhMucAsync()
        {
            using var context = DbContextHelper.GetContext();

            // SELECT * FROM DanhMucSanPham ORDER BY TenDanhMuc
            var list = await (
                from dm in context.DanhMucSanPhams
                orderby dm.TenDanhMuc
                select dm
            ).ToListAsync();

            cboDanhMuc.DataSource = list;
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "Iddm";
            cboDanhMuc.SelectedIndex = -1;
        }

        // ===== NẠP DỮ LIỆU SẢN PHẨM LÊN DATAGRIDVIEW (kèm ảnh) =====
        private async System.Threading.Tasks.Task LoadDataAsync(string tuKhoa = "")
        {
            using var context = DbContextHelper.GetContext();

            // Query Syntax kết hợp Include thông qua navigation property IddmNavigation
            // SELECT sp.*, dm.* FROM SanPham sp JOIN DanhMucSanPham dm ON sp.iddm = dm.iddm
            // WHERE sp.tensp LIKE '%tuKhoa%' ORDER BY sp.tensp
            var list = await (
                from sp in context.SanPhams.Include(x => x.IddmNavigation)
                where string.IsNullOrWhiteSpace(tuKhoa) || sp.Tensp.Contains(tuKhoa)
                orderby sp.Tensp
                select sp
            ).ToListAsync();

            dgv.Rows.Clear();
            foreach (var sp in list)
            {
                var img = ImageHelper.LoadImage(sp.HinhAnh);
                dgv.Rows.Add(
                    sp.Idsp,
                    img,
                    sp.Tensp,
                    sp.Soluong,
                    sp.Dvt,
                    sp.DonGia.ToString("N0"),
                    sp.IddmNavigation?.TenDanhMuc ?? "—"
                );
            }
        }

        // ===== TÍCH CHỌN DÒNG TRÊN LƯỚI → ĐỔ DỮ LIỆU + ẢNH LÊN CONTROL =====
        private async void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;

            _selectedId = Convert.ToInt32(dgv.CurrentRow.Cells["Idsp"].Value);

            using var context = DbContextHelper.GetContext();

            // Query Syntax tìm 1 sản phẩm theo khóa chính, kèm thông tin danh mục
            var sp = (
                from x in context.SanPhams.Include(n => n.IddmNavigation)
                where x.Idsp == _selectedId
                select x
            ).FirstOrDefault();

            if (sp == null) return;

            txtIdsp.Text = sp.Idsp.ToString();
            txtTenSp.Text = sp.Tensp;
            numSoLuong.Value = sp.Soluong;
            txtDvt.Text = sp.Dvt;
            txtDonGia.Text = sp.DonGia.ToString();
            cboDanhMuc.SelectedValue = sp.Iddm;

            _currentImageFileName = sp.HinhAnh;
            _tempSelectedImagePath = null; // reset — chưa chọn ảnh mới
            picHinhAnh.Image = ImageHelper.LoadImage(sp.HinhAnh);

            await System.Threading.Tasks.Task.CompletedTask; // giữ async signature cho nhất quán
        }

        // ===== CHỌN ẢNH TỪ MÁY TÍNH =====
        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "Hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Chọn ảnh sản phẩm"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _tempSelectedImagePath = ofd.FileName;            // chưa copy, chỉ ghi nhớ đường dẫn gốc
                picHinhAnh.Image = Image.FromFile(ofd.FileName);  // hiển thị preview ngay lập tức lên control
            }
        }

        // ===== LÀM MỚI FORM VỀ TRẠNG THÁI THÊM MỚI =====
        private void ClearForm()
        {
            _selectedId = null;
            _tempSelectedImagePath = null;
            _currentImageFileName = null;

            txtIdsp.Clear();
            txtTenSp.Clear();
            numSoLuong.Value = 0;
            txtDvt.Clear();
            txtDonGia.Clear();
            cboDanhMuc.SelectedIndex = -1;
            picHinhAnh.Image = ImageHelper.CreatePlaceholder();

            dgv.ClearSelection();
            txtTenSp.Focus();
        }

        // ===== KIỂM TRA DỮ LIỆU NHẬP =====
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenSp.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboDanhMuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtDonGia.Text, out decimal gia) || gia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Dữ liệu sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ===== THÊM SẢN PHẨM MỚI =====
        private async void BtnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string tenFileAnh = null;
            if (_tempSelectedImagePath != null)
                tenFileAnh = ImageHelper.CopyImageToFolder(_tempSelectedImagePath);

            var sp = new SanPham
            {
                Tensp = txtTenSp.Text.Trim(),
                Soluong = (int)numSoLuong.Value,
                Dvt = txtDvt.Text.Trim(),
                DonGia = decimal.Parse(txtDonGia.Text),
                Iddm = (int)cboDanhMuc.SelectedValue,
                HinhAnh = tenFileAnh
            };

            using (var context = DbContextHelper.GetContext())
            {
                context.SanPhams.Add(sp);
                await context.SaveChangesAsync();
            }

            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            await LoadDataAsync(); // làm mới DataGridView (+ảnh) ngay sau khi Thêm
        }

        // ===== SỬA SẢN PHẨM ĐANG CHỌN =====
        private async void BtnSua_Click(object sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trên lưới để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            using (var context = DbContextHelper.GetContext())
            {
                // Query Syntax tìm sản phẩm cần sửa theo khóa chính
                var sp = (
                    from x in context.SanPhams
                    where x.Idsp == _selectedId
                    select x
                ).FirstOrDefault();

                if (sp == null)
                {
                    MessageBox.Show("Sản phẩm không còn tồn tại!");
                    await LoadDataAsync();
                    return;
                }

                sp.Tensp = txtTenSp.Text.Trim();
                sp.Soluong = (int)numSoLuong.Value;
                sp.Dvt = txtDvt.Text.Trim();
                sp.DonGia = decimal.Parse(txtDonGia.Text);
                sp.Iddm = (int)cboDanhMuc.SelectedValue;

                // Chỉ thay ảnh nếu người dùng vừa chọn ảnh mới — nếu không, giữ nguyên ảnh cũ
                if (_tempSelectedImagePath != null)
                {
                    string anhCu = sp.HinhAnh;
                    sp.HinhAnh = ImageHelper.CopyImageToFolder(_tempSelectedImagePath);
                    ImageHelper.DeleteImageFile(anhCu);
                }

                await context.SaveChangesAsync();
            }

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            await LoadDataAsync(); // làm mới DataGridView (+ảnh) ngay sau khi Sửa
        }

        // ===== XÓA SẢN PHẨM ĐANG CHỌN =====
        private async void BtnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trên lưới để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var xacNhan = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan != DialogResult.Yes) return;

            using (var context = DbContextHelper.GetContext())
            {
                var sp = (
                    from x in context.SanPhams
                    where x.Idsp == _selectedId
                    select x
                ).FirstOrDefault();

                if (sp == null) return;

                string tenFileAnh = sp.HinhAnh;

                context.SanPhams.Remove(sp);
                await context.SaveChangesAsync();

                ImageHelper.DeleteImageFile(tenFileAnh); // dọn dẹp file ảnh vật lý sau khi xóa bản ghi
            }

            MessageBox.Show("Xóa thành công!");

            ClearForm();
            await LoadDataAsync(); // làm mới DataGridView ngay sau khi Xóa
        }

        // ===== NÚT LÀM MỚI =====
        private void BtnLamMoi_Click(object sender, EventArgs e) => ClearForm();

        // ===== TÌM KIẾM =====
        private async void BtnTimKiem_Click(object sender, EventArgs e)
            => await LoadDataAsync(txtTimKiem.Text.Trim());
    }
}