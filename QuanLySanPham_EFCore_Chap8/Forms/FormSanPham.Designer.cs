namespace QuanLySanPham_EFCore_Chap8
{
    partial class FormSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // ===== Khai báo các control của Form =====
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

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(23, 27);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(53, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "Mã SP:";
            // 
            // txtIdsp
            // 
            txtIdsp.BackColor = Color.Gainsboro;
            txtIdsp.Location = new Point(126, 23);
            txtIdsp.Margin = new Padding(3, 4, 3, 4);
            txtIdsp.Name = "txtIdsp";
            txtIdsp.ReadOnly = true;
            txtIdsp.Size = new Size(114, 27);
            txtIdsp.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(23, 73);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(55, 20);
            lbl2.TabIndex = 2;
            lbl2.Text = "Tên SP:";
            // 
            // txtTenSp
            // 
            txtTenSp.Location = new Point(126, 69);
            txtTenSp.Margin = new Padding(3, 4, 3, 4);
            txtTenSp.Name = "txtTenSp";
            txtTenSp.Size = new Size(251, 27);
            txtTenSp.TabIndex = 3;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(23, 120);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(72, 20);
            lbl3.TabIndex = 4;
            lbl3.Text = "Số lượng:";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(126, 116);
            numSoLuong.Margin = new Padding(3, 4, 3, 4);
            numSoLuong.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(114, 27);
            numSoLuong.TabIndex = 5;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(23, 167);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(40, 20);
            lbl4.TabIndex = 6;
            lbl4.Text = "ĐVT:";
            // 
            // txtDvt
            // 
            txtDvt.Location = new Point(126, 163);
            txtDvt.Margin = new Padding(3, 4, 3, 4);
            txtDvt.Name = "txtDvt";
            txtDvt.Size = new Size(114, 27);
            txtDvt.TabIndex = 7;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(23, 213);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(65, 20);
            lbl5.TabIndex = 8;
            lbl5.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(126, 209);
            txtDonGia.Margin = new Padding(3, 4, 3, 4);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(171, 27);
            txtDonGia.TabIndex = 9;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new Point(23, 260);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(79, 20);
            lbl6.TabIndex = 10;
            lbl6.Text = "Danh mục:";
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanhMuc.Location = new Point(126, 256);
            cboDanhMuc.Margin = new Padding(3, 4, 3, 4);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(251, 28);
            cboDanhMuc.TabIndex = 11;
            // 
            // picHinhAnh
            // 
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(400, 27);
            picHinhAnh.Margin = new Padding(3, 4, 3, 4);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(171, 199);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 12;
            picHinhAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(400, 237);
            btnChonAnh.Margin = new Padding(3, 4, 3, 4);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(171, 31);
            btnChonAnh.TabIndex = 13;
            btnChonAnh.Text = "Chọn ảnh...";
            btnChonAnh.Click += BtnChonAnh_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(617, 27);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 31);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.Click += BtnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(617, 73);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 31);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.Click += BtnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(731, 73);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 31);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.Click += BtnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(731, 27);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(103, 31);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += BtnLamMoi_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(23, 313);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(73, 20);
            lblTimKiem.TabIndex = 18;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(103, 309);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(285, 27);
            txtTimKiem.TabIndex = 19;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(400, 307);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 31);
            btnTimKiem.TabIndex = 20;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.Click += BtnTimKiem_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeight = 29;
            dgv.Location = new Point(23, 360);
            dgv.Margin = new Padding(3, 4, 3, 4);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1017, 373);
            dgv.TabIndex = 21;
            dgv.SelectionChanged += Dgv_SelectionChanged;

            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 800);
            Controls.Add(lbl1);
            Controls.Add(txtIdsp);
            Controls.Add(lbl2);
            Controls.Add(txtTenSp);
            Controls.Add(lbl3);
            Controls.Add(numSoLuong);
            Controls.Add(lbl4);
            Controls.Add(txtDvt);
            Controls.Add(lbl5);
            Controls.Add(txtDonGia);
            Controls.Add(lbl6);
            Controls.Add(cboDanhMuc);
            Controls.Add(picHinhAnh);
            Controls.Add(btnChonAnh);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgv);
            Margin = new Padding(3, 4, 3, 4);
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