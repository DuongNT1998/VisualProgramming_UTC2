namespace Validating_ErrrorProvider_ValidationRule
{
    partial class Formdangkyhoivien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.lblTitle = new System.Windows.Forms.Label();

            this.lblMaHV = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();

            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();

            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();

            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();

            this.lblHanMuc = new System.Windows.Forms.Label();
            this.txtHanMucTinDung = new System.Windows.Forms.TextBox();

            this.lblTinhThanh = new System.Windows.Forms.Label();
            this.cboTinhThanh = new System.Windows.Forms.ComboBox();

            this.lblGhiChu = new System.Windows.Forms.Label();

            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // ===== lblTitle =====
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ HỘI VIÊN - CỬA HÀNG ĐIỆN MÁY XYZ";

            // ===== lblMaHV / txtMaHV =====
            this.lblMaHV.AutoSize = true;
            this.lblMaHV.Location = new System.Drawing.Point(20, 63);
            this.lblMaHV.Name = "lblMaHV";
            this.lblMaHV.Size = new System.Drawing.Size(80, 15);
            this.lblMaHV.TabIndex = 1;
            this.lblMaHV.Text = "Mã hội viên:";

            this.txtMaHV.Location = new System.Drawing.Point(200, 60);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.ReadOnly = true;
            this.txtMaHV.Size = new System.Drawing.Size(150, 23);
            this.txtMaHV.TabIndex = 2;
            this.txtMaHV.TabStop = false;
            this.txtMaHV.BackColor = System.Drawing.SystemColors.Control;

            // ===== lblHoTen / txtHoTen =====
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 98);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(100, 15);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ và tên (*):";

            this.txtHoTen.Location = new System.Drawing.Point(200, 95);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(320, 23);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoTen_Validating);
            this.txtHoTen.Validated += new System.EventHandler(this.txt_Validated);

            // ===== lblNgaySinh / txtNgaySinh =====
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 133);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(200, 15);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày sinh (dd/MM/yyyy) (*):";

            this.txtNgaySinh.Location = new System.Drawing.Point(200, 130);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(150, 23);
            this.txtNgaySinh.TabIndex = 6;
            this.txtNgaySinh.Validating += new System.ComponentModel.CancelEventHandler(this.txtNgaySinh_Validating);
            this.txtNgaySinh.Validated += new System.EventHandler(this.txt_Validated);

            // ===== lblEmail / txtEmail =====
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 168);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email (*):";

            this.txtEmail.Location = new System.Drawing.Point(200, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 23);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.txt_Validated);

            // ===== lblSDT / txtSDT =====
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(20, 203);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(115, 15);
            this.lblSDT.TabIndex = 9;
            this.lblSDT.Text = "Số điện thoại (*):";

            this.txtSDT.Location = new System.Drawing.Point(200, 200);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(150, 23);
            this.txtSDT.TabIndex = 10;
            this.txtSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtSDT_Validating);
            this.txtSDT.Validated += new System.EventHandler(this.txt_Validated);

            // ===== lblHanMuc / txtHanMucTinDung =====
            this.lblHanMuc.AutoSize = true;
            this.lblHanMuc.Location = new System.Drawing.Point(20, 238);
            this.lblHanMuc.Name = "lblHanMuc";
            this.lblHanMuc.Size = new System.Drawing.Size(240, 15);
            this.lblHanMuc.TabIndex = 11;
            this.lblHanMuc.Text = "Hạn mức tín dụng đăng ký (VNĐ) (*):";

            this.txtHanMucTinDung.Location = new System.Drawing.Point(270, 235);
            this.txtHanMucTinDung.Name = "txtHanMucTinDung";
            this.txtHanMucTinDung.Size = new System.Drawing.Size(150, 23);
            this.txtHanMucTinDung.TabIndex = 12;
            this.txtHanMucTinDung.Text = "0";
            this.txtHanMucTinDung.Validating += new System.ComponentModel.CancelEventHandler(this.txtHanMucTinDung_Validating);
            this.txtHanMucTinDung.Validated += new System.EventHandler(this.txt_Validated);

            // ===== lblTinhThanh / cboTinhThanh =====
            this.lblTinhThanh.AutoSize = true;
            this.lblTinhThanh.Location = new System.Drawing.Point(20, 273);
            this.lblTinhThanh.Name = "lblTinhThanh";
            this.lblTinhThanh.Size = new System.Drawing.Size(140, 15);
            this.lblTinhThanh.TabIndex = 13;
            this.lblTinhThanh.Text = "Tỉnh/Thành phố (*):";

            this.cboTinhThanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhThanh.FormattingEnabled = true;
            this.cboTinhThanh.Items.AddRange(new object[] {
                "-- Chọn tỉnh/thành --",
                "Hà Nội",
                "TP. Hồ Chí Minh",
                "Đà Nẵng",
                "Hải Phòng",
                "Cần Thơ"});
            this.cboTinhThanh.Location = new System.Drawing.Point(200, 270);
            this.cboTinhThanh.Name = "cboTinhThanh";
            this.cboTinhThanh.Size = new System.Drawing.Size(220, 23);
            this.cboTinhThanh.TabIndex = 14;
            this.cboTinhThanh.SelectedIndex = 0;
            this.cboTinhThanh.Validating += new System.ComponentModel.CancelEventHandler(this.cboTinhThanh_Validating);
            this.cboTinhThanh.Validated += new System.EventHandler(this.txt_Validated);

            // ===== lblGhiChu =====
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.ForeColor = System.Drawing.Color.Gray;
            this.lblGhiChu.Location = new System.Drawing.Point(20, 310);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(400, 15);
            this.lblGhiChu.TabIndex = 15;
            this.lblGhiChu.Text = "(*) Bắt buộc — di chuyển (Tab) qua field khác để kiểm tra ngay";

            // ===== btnLuu =====
            this.btnLuu.Location = new System.Drawing.Point(200, 345);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 35);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu hội viên";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // ===== btnHuy =====
            // CausesValidation = false: cho phép Hủy/Làm mới ngay cả khi
            // đang có field nhập dở/không hợp lệ, không bị Validating chặn lại.
            this.btnHuy.CausesValidation = false;
            this.btnHuy.Location = new System.Drawing.Point(330, 345);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 35);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy / Làm mới";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // ===== FormDangKyHoiVien =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // QUAN TRỌNG: EnablePreventFocusChange khiến focus KHÔNG rời khỏi
            // field đang lỗi khi Validating có e.Cancel = true (đúng nguyên tắc
            // "Fail Fast & Fail Clear" nêu trong slide 65).
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;

            this.ClientSize = new System.Drawing.Size(560, 410);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMaHV);
            this.Controls.Add(this.txtMaHV);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblHanMuc);
            this.Controls.Add(this.txtHanMucTinDung);
            this.Controls.Add(this.lblTinhThanh);
            this.Controls.Add(this.cboTinhThanh);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDangKyHoiVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký Hội viên - Cửa hàng Điện máy XYZ";

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblMaHV;
        private System.Windows.Forms.TextBox txtMaHV;

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;

        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtNgaySinh;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;

        private System.Windows.Forms.Label lblHanMuc;
        private System.Windows.Forms.TextBox txtHanMucTinDung;

        private System.Windows.Forms.Label lblTinhThanh;
        private System.Windows.Forms.ComboBox cboTinhThanh;

        private System.Windows.Forms.Label lblGhiChu;

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
