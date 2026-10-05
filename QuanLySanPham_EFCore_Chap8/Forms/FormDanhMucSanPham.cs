using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLySanPham_EFCore_Chap8.Helpers;
using QuanLySanPham_EFCore_Chap8.Models;

namespace QuanLySanPham_EFCore_Chap8
{
    public partial class FormDanhMucSanPham : Form
    {
        // null = đang ở chế độ Thêm mới; có giá trị = đang chọn 1 dòng để Sửa/Xóa
        private int? _selectedId = null;

        public FormDanhMucSanPham()
        {
            InitializeComponent();
            SetupDataGridViewColumns();
            _ = LoadDataAsync();
        }
        private void SetupDataGridViewColumns()
        {
            if (dgv.Columns.Count > 0) return;
            dgv.Columns.Add("Iddm", "Mã DM");
            dgv.Columns.Add("TenDanhMuc", "Tên danh mục");
            dgv.Columns.Add("CreateAt", "Ngày tạo");
            dgv.Columns.Add("UpdateAt", "Cập nhật");
        }

        // ===== NẠP DỮ LIỆU LÊN DATAGRIDVIEW =====
        private async System.Threading.Tasks.Task LoadDataAsync(string tuKhoa = "")
        {
            using var context = DbContextHelper.GetContext();

            // Cú pháp Query Syntax — đọc gần giống câu lệnh SQL: SELECT ... FROM ... WHERE ... ORDER BY ...
            var list = await (
                from dm in context.DanhMucSanPhams
                where string.IsNullOrWhiteSpace(tuKhoa) || dm.TenDanhMuc.Contains(tuKhoa)
                orderby dm.TenDanhMuc
                select dm
            ).ToListAsync();

            dgv.Rows.Clear();
            foreach (var dm in list)
            {
                dgv.Rows.Add(dm.Iddm, dm.TenDanhMuc,
                    dm.CreateAt.ToString("dd/MM/yyyy HH:mm"),
                    dm.UpdateAt?.ToString("dd/MM/yyyy HH:mm") ?? "—");
            }
        }

        // ===== TÍCH CHỌN DÒNG TRÊN LƯỚI → ĐỔ DỮ LIỆU LÊN CONTROL =====
        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;

            _selectedId = Convert.ToInt32(dgv.CurrentRow.Cells["Iddm"].Value);
            txtIddm.Text = _selectedId.ToString();
            txtTenDanhMuc.Text = dgv.CurrentRow.Cells["TenDanhMuc"].Value.ToString();
            lblCreateAt.Text = "Ngày tạo: " + dgv.CurrentRow.Cells["CreateAt"].Value;
            lblUpdateAt.Text = "Cập nhật: " + dgv.CurrentRow.Cells["UpdateAt"].Value;
        }

        // ===== LÀM MỚI FORM VỀ TRẠNG THÁI THÊM MỚI =====
        private void ClearForm()
        {
            _selectedId = null;
            txtIddm.Clear();
            txtTenDanhMuc.Clear();
            lblCreateAt.Text = "Ngày tạo: —";
            lblUpdateAt.Text = "Cập nhật: —";
            dgv.ClearSelection();
            txtTenDanhMuc.Focus();
        }

        // ===== KIỂM TRA DỮ LIỆU NHẬP =====
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenDanhMuc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDanhMuc.Focus();
                return false;
            }
            return true;
        }

        // ===== THÊM DANH MỤC MỚI =====
        private async void BtnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var dm = new DanhMucSanPham
            {
                TenDanhMuc = txtTenDanhMuc.Text.Trim(),
                CreateAt = DateTime.Now
            };

            using (var context = DbContextHelper.GetContext())
            {
                context.DanhMucSanPhams.Add(dm);
                await context.SaveChangesAsync();
            }

            MessageBox.Show("Thêm danh mục thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            await LoadDataAsync(); // làm mới lưới ngay sau khi Thêm
        }

        // ===== SỬA DANH MỤC ĐANG CHỌN =====
        private async void BtnSua_Click(object sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn một danh mục trên lưới để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            using (var context = DbContextHelper.GetContext())
            {
                // Query Syntax tìm 1 bản ghi theo khóa chính
                var dm = (
                    from x in context.DanhMucSanPhams
                    where x.Iddm == _selectedId
                    select x
                ).FirstOrDefault();

                if (dm == null)
                {
                    MessageBox.Show("Danh mục không còn tồn tại!");
                    await LoadDataAsync();
                    return;
                }

                dm.TenDanhMuc = txtTenDanhMuc.Text.Trim();
                dm.UpdateAt = DateTime.Now;
                await context.SaveChangesAsync();
            }

            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            await LoadDataAsync(); // làm mới lưới ngay sau khi Sửa
        }

        // ===== XÓA DANH MỤC ĐANG CHỌN =====
        private async void BtnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn một danh mục trên lưới để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var xacNhan = MessageBox.Show("Bạn có chắc muốn xóa danh mục này?\n" +
                "(Nếu còn sản phẩm thuộc danh mục này, thao tác xóa sẽ thất bại)",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan != DialogResult.Yes) return;

            using (var context = DbContextHelper.GetContext())
            {
                var dm = (
                    from x in context.DanhMucSanPhams
                    where x.Iddm == _selectedId
                    select x
                ).FirstOrDefault();

                if (dm == null) return;

                try
                {
                    context.DanhMucSanPhams.Remove(dm);
                    await context.SaveChangesAsync();
                    MessageBox.Show("Xóa thành công!");
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Không thể xóa! Danh mục này đang có sản phẩm liên kết.\n" +
                        "Vui lòng xóa/chuyển sản phẩm sang danh mục khác trước.",
                        "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ClearForm();
            await LoadDataAsync(); // làm mới lưới ngay sau khi Xóa
        }

        // ===== NÚT LÀM MỚI =====
        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // ===== TÌM KIẾM =====
        private async void BtnTimKiem_Click(object sender, EventArgs e)
        {
            await LoadDataAsync(txtTimKiem.Text.Trim());
        }
    }
}