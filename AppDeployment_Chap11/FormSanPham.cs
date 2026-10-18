using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using AppDeployment_Chap11.Helpers;
using AppDeployment_Chap11.Models;
using AppDeployment_Chap11.Services;
using Serilog;

namespace AppDeployment_Chap11
{
    public partial class FormSanPham : Form
    {
        private int? _selectedId = null;
        private string _tempSelectedImagePath = null;
        private string _currentImageFileName = null;

        // Section 9.4: control thêm bằng code (không đụng Designer của Chương 8)
        private Button btnTyGia;
        private Label lblKetQuaTyGia;

        public FormSanPham()
        {
            InitializeComponent();
            ApplyLanguage();      // Section 9.4: gán text theo ngôn ngữ hiện tại
            SetupDataGridViewColumns();
            SetupApiControls();   // thêm nút gọi API tỷ giá

            picHinhAnh.Image = ImageHelper.CreatePlaceholder();
            _ = LoadDanhMucAsync();
            _ = LoadDataAsync();
        }

        private void SetupDataGridViewColumns()
        {
            if (dgv.Columns.Count > 0) return;
            dgv.AutoGenerateColumns = false;
            dgv.RowTemplate.Height = 60;
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Idsp", HeaderText = Strings.Get("ColMa"), Width = 60 });
            dgv.Columns.Add(new DataGridViewImageColumn { Name = "HinhAnh", HeaderText = Strings.Get("ColAnh"), Width = 70, ImageLayout = DataGridViewImageCellLayout.Zoom });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenSp", HeaderText = Strings.Get("ColTen"), Width = 200 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoLuong", HeaderText = Strings.Get("ColSL"), Width = 60 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Dvt", HeaderText = Strings.Get("ColDvt"), Width = 60 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "DonGia", HeaderText = Strings.Get("ColGia"), Width = 100 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenDanhMuc", HeaderText = Strings.Get("ColDanhMuc"), Width = 180 });
        }

        // ===== Section 9.4: gán text của các control đã dựng trong Designer theo ngôn ngữ hiện tại =====
        private void ApplyLanguage()
        {
            Text = Strings.Get("QuanLySanPham");
            lbl1.Text = Strings.Get("MaSP");
            lbl2.Text = Strings.Get("TenSP");
            lbl3.Text = Strings.Get("SoLuong");
            lbl4.Text = Strings.Get("Dvt");
            lbl5.Text = Strings.Get("DonGia");
            lbl6.Text = Strings.Get("DanhMuc");
            lblTimKiem.Text = Strings.Get("TimKiem");
            btnChonAnh.Text = Strings.Get("ChonAnh");
            btnThem.Text = Strings.Get("Them");
            btnSua.Text = Strings.Get("Sua");
            btnXoa.Text = Strings.Get("Xoa");
            btnLamMoi.Text = Strings.Get("LamMoi");
            btnTimKiem.Text = Strings.Get("Tim");
        }

        // ===== Section 9.4: thêm nút "Quy đổi tỷ giá" gọi REST API =====
        private void SetupApiControls()
        {
            btnTyGia = new Button
            {
                Text = Strings.Get("TyGia"),
                Location = new Point(400, 276),
                Size = new Size(171, 31)
            };
            btnTyGia.Click += BtnTyGia_Click;

            lblKetQuaTyGia = new Label
            {
                Location = new Point(400, 310),
                Size = new Size(260, 40),
                ForeColor = Color.DarkGreen
            };

            Controls.Add(btnTyGia);
            Controls.Add(lblKetQuaTyGia);
        }

        private async System.Threading.Tasks.Task LoadDanhMucAsync()
        {
            using var context = DbContextHelper.GetContext();
            var list = await (from dm in context.DanhMucSanPhams orderby dm.TenDanhMuc select dm).ToListAsync();
            cboDanhMuc.DataSource = list;
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "Iddm";
            cboDanhMuc.SelectedIndex = -1;
        }

        private async System.Threading.Tasks.Task LoadDataAsync(string tuKhoa = "")
        {
            using var context = DbContextHelper.GetContext();
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
                dgv.Rows.Add(sp.Idsp, img, sp.Tensp, sp.Soluong, sp.Dvt,
                    sp.DonGia.ToString("N0"), sp.IddmNavigation?.TenDanhMuc ?? "—");
            }
        }

        private async void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            _selectedId = Convert.ToInt32(dgv.CurrentRow.Cells["Idsp"].Value);
            using var context = DbContextHelper.GetContext();
            var sp = (from x in context.SanPhams.Include(n => n.IddmNavigation)
                      where x.Idsp == _selectedId
                      select x).FirstOrDefault();
            if (sp == null) return;

            txtIdsp.Text = sp.Idsp.ToString();
            txtTenSp.Text = sp.Tensp;
            numSoLuong.Value = sp.Soluong;
            txtDvt.Text = sp.Dvt;
            txtDonGia.Text = sp.DonGia.ToString();
            cboDanhMuc.SelectedValue = sp.Iddm;
            _currentImageFileName = sp.HinhAnh;
            _tempSelectedImagePath = null;
            picHinhAnh.Image = ImageHelper.LoadImage(sp.HinhAnh);
            await System.Threading.Tasks.Task.CompletedTask;
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "Hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
                Title = Strings.Get("ChonAnh")
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _tempSelectedImagePath = ofd.FileName;
                picHinhAnh.Image = Image.FromFile(ofd.FileName);
            }
        }

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

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenSp.Text))
            {
                MessageBox.Show(Strings.Get("ThieuTenSP"), "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private async void BtnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
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
                Log.Information("Thêm sản phẩm {Ten} thành công", sp.Tensp); // Section 9.3
                MessageBox.Show(Strings.Get("ThemThanhCong"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi thêm sản phẩm {Ten}", txtTenSp.Text); // Section 9.3
                MessageBox.Show(Strings.Get("LoiChung"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSua_Click(object sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trên lưới để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;
            try
            {
                using (var context = DbContextHelper.GetContext())
                {
                    var sp = (from x in context.SanPhams where x.Idsp == _selectedId select x).FirstOrDefault();
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
                    if (_tempSelectedImagePath != null)
                    {
                        string anhCu = sp.HinhAnh;
                        sp.HinhAnh = ImageHelper.CopyImageToFolder(_tempSelectedImagePath);
                        ImageHelper.DeleteImageFile(anhCu);
                    }
                    await context.SaveChangesAsync();
                }
                Log.Information("Cập nhật sản phẩm Id={Id} thành công", _selectedId);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi sửa sản phẩm Id={Id}", _selectedId);
                MessageBox.Show(Strings.Get("LoiChung"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trên lưới để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var xacNhan = MessageBox.Show(Strings.Get("XacNhanXoa"), "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan != DialogResult.Yes) return;
            try
            {
                using (var context = DbContextHelper.GetContext())
                {
                    var sp = (from x in context.SanPhams where x.Idsp == _selectedId select x).FirstOrDefault();
                    if (sp == null) return;
                    string tenFileAnh = sp.HinhAnh;
                    context.SanPhams.Remove(sp);
                    await context.SaveChangesAsync();
                    ImageHelper.DeleteImageFile(tenFileAnh);
                }
                Log.Information("Xóa sản phẩm Id={Id} thành công", _selectedId);
                MessageBox.Show("Xóa thành công!");
                ClearForm();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi xóa sản phẩm Id={Id}", _selectedId);
                MessageBox.Show(Strings.Get("LoiChung"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e) => ClearForm();

        private async void BtnTimKiem_Click(object sender, EventArgs e)
            => await LoadDataAsync(txtTimKiem.Text.Trim());

        // ===== Section 9.4: Gọi REST API tỷ giá — async/await, xử lý lỗi, ghi log =====
        private async void BtnTyGia_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGiaVnd) || donGiaVnd <= 0)
            {
                MessageBox.Show("Nhập Đơn giá (VND) hợp lệ trước khi quy đổi.");
                return;
            }

            btnTyGia.Enabled = false;
            lblKetQuaTyGia.Text = "Đang lấy tỷ giá...";
            try
            {
                // 1 USD = ? VND
                decimal usdToVnd = await TyGiaService.LayTyGiaAsync("USD");
                decimal donGiaUsd = donGiaVnd / usdToVnd;

                lblKetQuaTyGia.Text = $"{donGiaVnd:N0} VND ≈ {donGiaUsd:N2} USD\n(1 USD = {usdToVnd:N0} VND)";
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                Log.Error(ex, "Lỗi mạng khi gọi API tỷ giá");
                lblKetQuaTyGia.Text = "";
                MessageBox.Show(Strings.Get("LoiMang"), "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TaskCanceledException ex)
            {
                Log.Error(ex, "Timeout khi gọi API tỷ giá");
                lblKetQuaTyGia.Text = "";
                MessageBox.Show(Strings.Get("LoiMang"), "Hết thời gian chờ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi không xác định khi gọi API tỷ giá");
                lblKetQuaTyGia.Text = "";
                MessageBox.Show(Strings.Get("LoiChung"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnTyGia.Enabled = true;
            }
        }
    }
}
