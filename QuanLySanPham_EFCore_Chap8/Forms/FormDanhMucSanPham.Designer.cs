namespace QuanLySanPham_EFCore_Chap8
{
    partial class FormDanhMucSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // ===== Khai báo các control của Form =====
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtIddm;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Label lblCreateAt;
        private System.Windows.Forms.Label lblUpdateAt;
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
            this.components = new System.ComponentModel.Container();

            this.lbl1 = new System.Windows.Forms.Label();
            this.txtIddm = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.lblCreateAt = new System.Windows.Forms.Label();
            this.lblUpdateAt = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(20, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Text = "Mã DM:";

            // 
            // txtIddm
            // 
            this.txtIddm.Location = new System.Drawing.Point(120, 17);
            this.txtIddm.Name = "txtIddm";
            this.txtIddm.Width = 100;
            this.txtIddm.ReadOnly = true;
            this.txtIddm.BackColor = System.Drawing.Color.Gainsboro;

            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(20, 55);
            this.lbl2.Name = "lbl2";
            this.lbl2.Text = "Tên danh mục:";

            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(120, 52);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Width = 300;

            // 
            // lblCreateAt
            // 
            this.lblCreateAt.AutoSize = true;
            this.lblCreateAt.Location = new System.Drawing.Point(20, 90);
            this.lblCreateAt.Name = "lblCreateAt";
            this.lblCreateAt.Text = "Ngày tạo: —";

            // 
            // lblUpdateAt
            // 
            this.lblUpdateAt.AutoSize = true;
            this.lblUpdateAt.Location = new System.Drawing.Point(250, 90);
            this.lblUpdateAt.Name = "lblUpdateAt";
            this.lblUpdateAt.Text = "Cập nhật: —";

            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(450, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Width = 90;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);

            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(450, 50);
            this.btnSua.Name = "btnSua";
            this.btnSua.Width = 90;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(550, 50);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Width = 90;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);

            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(550, 15);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Width = 90;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);

            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(20, 125);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Text = "Tìm kiếm:";

            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(90, 122);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Width = 250;

            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(350, 120);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Width = 70;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);

            // 
            // dgv
            // 
            this.dgv.Location = new System.Drawing.Point(20, 160);
            this.dgv.Size = new System.Drawing.Size(660, 280);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.MultiSelect = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            
            this.dgv.SelectionChanged += new System.EventHandler(this.Dgv_SelectionChanged);

            // 
            // FormDanhMucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Danh mục Sản phẩm";
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtIddm);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.lblCreateAt);
            this.Controls.Add(this.lblUpdateAt);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgv);

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}