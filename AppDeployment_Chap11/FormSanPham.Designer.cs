

namespace AppDeployment_Chap11
{
    partial class FormSanPham
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtIdsp;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lbl1 = new Label();
            txtIdsp = new TextBox();
            lbl2 = new Label();
            txtTenSp = new TextBox();
            lbl3 = new Label();
            numSoLuong = new NumericUpDown();
            lbl4 = new Label();
            txtDvt = new TextBox();
            lbl5 = new Label();
            txtDonGia = new TextBox();
            lbl6 = new Label();
            cboDanhMuc = new ComboBox();
            picHinhAnh = new PictureBox();
            btnChonAnh = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();

            lbl1.AutoSize = true; lbl1.Location = new Point(23, 27); lbl1.Text = "Mã SP:";
            txtIdsp.BackColor = Color.Gainsboro; txtIdsp.Location = new Point(126, 23); txtIdsp.Name = "txtIdsp"; txtIdsp.ReadOnly = true; txtIdsp.Size = new Size(114, 27);
            lbl2.AutoSize = true; lbl2.Location = new Point(23, 73); lbl2.Text = "Tên SP:";
            txtTenSp.Location = new Point(126, 69); txtTenSp.Name = "txtTenSp"; txtTenSp.Size = new Size(251, 27);
            lbl3.AutoSize = true; lbl3.Location = new Point(23, 120); lbl3.Text = "Số lượng:";
            numSoLuong.Location = new Point(126, 116); numSoLuong.Maximum = new decimal(new int[] { 999999, 0, 0, 0 }); numSoLuong.Name = "numSoLuong"; numSoLuong.Size = new Size(114, 27);
            lbl4.AutoSize = true; lbl4.Location = new Point(23, 167); lbl4.Text = "ĐVT:";
            txtDvt.Location = new Point(126, 163); txtDvt.Name = "txtDvt"; txtDvt.Size = new Size(114, 27);
            lbl5.AutoSize = true; lbl5.Location = new Point(23, 213); lbl5.Text = "Đơn giá:";
            txtDonGia.Location = new Point(126, 209); txtDonGia.Name = "txtDonGia"; txtDonGia.Size = new Size(171, 27);
            lbl6.AutoSize = true; lbl6.Location = new Point(23, 260); lbl6.Text = "Danh mục:";
            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList; cboDanhMuc.Location = new Point(126, 256); cboDanhMuc.Name = "cboDanhMuc"; cboDanhMuc.Size = new Size(251, 28);
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle; picHinhAnh.Location = new Point(400, 27); picHinhAnh.Name = "picHinhAnh"; picHinhAnh.Size = new Size(171, 199); picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom; picHinhAnh.TabStop = false;
            btnChonAnh.Location = new Point(400, 237); btnChonAnh.Name = "btnChonAnh"; btnChonAnh.Size = new Size(171, 31); btnChonAnh.Text = "Chọn ảnh..."; btnChonAnh.Click += BtnChonAnh_Click;
            btnThem.Location = new Point(617, 27); btnThem.Name = "btnThem"; btnThem.Size = new Size(103, 31); btnThem.Text = "Thêm"; btnThem.Click += BtnThem_Click;
            btnSua.Location = new Point(617, 73); btnSua.Name = "btnSua"; btnSua.Size = new Size(103, 31); btnSua.Text = "Sửa"; btnSua.Click += BtnSua_Click;
            btnXoa.Location = new Point(731, 73); btnXoa.Name = "btnXoa"; btnXoa.Size = new Size(103, 31); btnXoa.Text = "Xóa"; btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Location = new Point(731, 27); btnLamMoi.Name = "btnLamMoi"; btnLamMoi.Size = new Size(103, 31); btnLamMoi.Text = "Làm mới"; btnLamMoi.Click += BtnLamMoi_Click;
            lblTimKiem.AutoSize = true; lblTimKiem.Location = new Point(23, 313); lblTimKiem.Text = "Tìm kiếm:";
            txtTimKiem.Location = new Point(103, 309); txtTimKiem.Name = "txtTimKiem"; txtTimKiem.Size = new Size(285, 27);
            btnTimKiem.Location = new Point(400, 360); btnTimKiem.Name = "btnTimKiem"; btnTimKiem.Size = new Size(80, 31); btnTimKiem.Text = "Tìm"; btnTimKiem.Click += BtnTimKiem_Click;
            dgv.AllowUserToAddRows = false; dgv.AllowUserToDeleteRows = false; dgv.ColumnHeadersHeight = 29; dgv.Location = new Point(23, 400); dgv.MultiSelect = false; dgv.Name = "dgv"; dgv.ReadOnly = true; dgv.RowHeadersWidth = 51; dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dgv.Size = new Size(1017, 373); dgv.SelectionChanged += Dgv_SelectionChanged;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 800);
            Controls.Add(lbl1); Controls.Add(txtIdsp); Controls.Add(lbl2); Controls.Add(txtTenSp);
            Controls.Add(lbl3); Controls.Add(numSoLuong); Controls.Add(lbl4); Controls.Add(txtDvt);
            Controls.Add(lbl5); Controls.Add(txtDonGia); Controls.Add(lbl6); Controls.Add(cboDanhMuc);
            Controls.Add(picHinhAnh); Controls.Add(btnChonAnh); Controls.Add(btnThem); Controls.Add(btnSua);
            Controls.Add(btnXoa); Controls.Add(btnLamMoi); Controls.Add(lblTimKiem); Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem); Controls.Add(dgv);
            Name = "FormSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Sản phẩm";
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
