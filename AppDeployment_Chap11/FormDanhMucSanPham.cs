using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using AppDeployment_Chap11.Helpers;
using AppDeployment_Chap11.Models;
using Serilog;

namespace AppDeployment_Chap11
{
    public partial class FormDanhMucSanPham : Form
    {
        private int? _selectedId = null;

        public FormDanhMucSanPham()
        {
            InitializeComponent();
            ApplyLanguage();
            SetupDataGridViewColumns();
            _ = LoadDataAsync();
        }

        private void ApplyLanguage()
        {
            Text = Strings.Get("QuanLyDanhMuc");
            lbl1.Text = Strings.Get("MaDM");
            lbl2.Text = Strings.Get("TenDM");
            lblCreateAt.Text = Strings.Get("NgayTao") + " —";
            lblUpdateAt.Text = Strings.Get("CapNhat") + " —";
            lblTimKiem.Text = Strings.Get("TimKiem");
            btnThem.Text = Strings.Get("Them");
            btnSua.Text = Strings.Get("Sua");
            btnXoa.Text = Strings.Get("Xoa");
            btnLamMoi.Text = Strings.Get("LamMoi");
            btnTimKiem.Text = Strings.Get("Tim");
        }

        private void SetupDataGridViewColumns()
        {
            if (dgv.Columns.Count > 0) return;
            dgv.Columns.Add("Iddm", Strings.Get("ColMaDM"));
            dgv.Columns.Add("TenDanhMuc", Strings.Get("ColTenDM"));
            dgv.Columns.Add("CreateAt", Strings.Get("ColNgayTao"));
            dgv.Columns.Add("UpdateAt", Strings.Get("ColCapNhat"));
        }

        private async System.Threading.Tasks.Task LoadDataAsync(string tuKhoa = "")
        {
            using var context = DbContextHelper.GetContext();
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

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            _selectedId = Convert.ToInt32(dgv.CurrentRow.Cells["Iddm"].Value);
            txtIddm.Text = _selectedId.ToString();
            txtTenDanhMuc.Text = dgv.CurrentRow.Cells["TenDanhMuc"].Value.ToString();
            lblCreateAt.Text = Strings.Get("NgayTao") + " " + dgv.CurrentRow.Cells["CreateAt"].Value;
            lblUpdateAt.Text = Strings.Get("CapNhat") + " " + dgv.CurrentRow.Cells["UpdateAt"].Value;
        }

        private void ClearForm()
        {
            _selectedId = null;
            txtIddm.Clear();
            txtTenDanhMuc.Clear();
            lblCreateAt.Text = Strings.Get("NgayTao") + " —";
            lblUpdateAt.Text = Strings.Get("CapNhat") + " —";
            dgv.ClearSelection();
            txtTenDanhMuc.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenDanhMuc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDanhMuc.Focus();
                return false;
            }
            return true;
        }

        private async void BtnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                var dm = new DanhMucSanPham { TenDanhMuc = txtTenDanhMuc.Text.Trim(), CreateAt = DateTime.Now };
                using (var context = DbContextHelper.GetContext())
                {
                    context.DanhMucSanPhams.Add(dm);
                    await context.SaveChangesAsync();
                }
                Log.Information("Thêm danh mục {Ten} thành công", dm.TenDanhMuc);
                MessageBox.Show("Thêm danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi thêm danh mục {Ten}", txtTenDanhMuc.Text);
                MessageBox.Show(Strings.Get("LoiChung"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSua_Click(object sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn một danh mục trên lưới để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;
            try
            {
                using (var context = DbContextHelper.GetContext())
                {
                    var dm = (from x in context.DanhMucSanPhams where x.Iddm == _selectedId select x).FirstOrDefault();
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
                Log.Information("Cập nhật danh mục Id={Id} thành công", _selectedId);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi sửa danh mục Id={Id}", _selectedId);
                MessageBox.Show(Strings.Get("LoiChung"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn một danh mục trên lưới để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var xacNhan = MessageBox.Show("Bạn có chắc muốn xóa danh mục này?\n(Nếu còn sản phẩm thuộc danh mục này, thao tác xóa sẽ thất bại)",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan != DialogResult.Yes) return;

            using (var context = DbContextHelper.GetContext())
            {
                var dm = (from x in context.DanhMucSanPhams where x.Iddm == _selectedId select x).FirstOrDefault();
                if (dm == null) return;
                try
                {
                    context.DanhMucSanPhams.Remove(dm);
                    await context.SaveChangesAsync();
                    Log.Information("Xóa danh mục Id={Id} thành công", _selectedId);
                    MessageBox.Show("Xóa thành công!");
                }
                catch (DbUpdateException ex)
                {
                    Log.Warning(ex, "Không thể xóa danh mục Id={Id} do ràng buộc dữ liệu", _selectedId);
                    MessageBox.Show("Không thể xóa! Danh mục này đang có sản phẩm liên kết.\nVui lòng xóa/chuyển sản phẩm sang danh mục khác trước.",
                        "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            ClearForm();
            await LoadDataAsync();
        }

        private void BtnLamMoi_Click(object sender, EventArgs e) => ClearForm();

        private async void BtnTimKiem_Click(object sender, EventArgs e)
            => await LoadDataAsync(txtTimKiem.Text.Trim());
    }
}