namespace FocusManagement_TabIndex_TabStop
{
    partial class Form1
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
            this.lblMauSP = new System.Windows.Forms.Label();

            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();

            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();

            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();

            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();

            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();

            this.btnThemDong = new System.Windows.Forms.Button();
            this.lstHoaDon = new System.Windows.Forms.ListBox();

            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();

            this.lblActiveControl = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // ===== lblTitle =====
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LẬP HÓA ĐƠN BÁN HÀNG - QUẦY THU NGÂN";

            // ===== lblMauSP =====
            this.lblMauSP.AutoSize = true;
            this.lblMauSP.ForeColor = System.Drawing.Color.Gray;
            this.lblMauSP.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblMauSP.Location = new System.Drawing.Point(20, 45);
            this.lblMauSP.Name = "lblMauSP";
            this.lblMauSP.Size = new System.Drawing.Size(560, 15);
            this.lblMauSP.TabIndex = 1;
            this.lblMauSP.Text = "Mã SP mẫu để test: SP001, SP002, SP003, SP004 (gõ mã rồi nhấn Enter để tra cứu)";

            // ===== lblMaSP / txtMaSP =====
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(20, 78);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(230, 15);
            this.lblMaSP.TabIndex = 2;
            this.lblMaSP.Text = "Mã sản phẩm (quét/gõ rồi Enter):";

            this.txtMaSP.Location = new System.Drawing.Point(280, 75);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(150, 23);
            this.txtMaSP.TabIndex = 0; // Tab đầu tiên
            this.txtMaSP.Enter += new System.EventHandler(this.txt_Enter);
            this.txtMaSP.Leave += new System.EventHandler(this.txtMaSP_Leave);

            // ===== lblTenSP / txtTenSP (chỉ hiển thị, không nhận Tab) =====
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(20, 113);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(90, 15);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.Text = "Tên sản phẩm:";

            this.txtTenSP.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenSP.Location = new System.Drawing.Point(280, 110);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(300, 23);
            this.txtTenSP.TabStop = false; // KHÔNG cho Tab vào field auto-fill này

            // ===== lblSoLuong / txtSoLuong =====
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(20, 148);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 15);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng:";

            this.txtSoLuong.Location = new System.Drawing.Point(280, 145);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 23);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.Text = "1";
            this.txtSoLuong.Enter += new System.EventHandler(this.txt_Enter);
            this.txtSoLuong.Leave += new System.EventHandler(this.txtSoLuong_Leave);

            // ===== lblDonGia / txtDonGia =====
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(20, 183);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(90, 15);
            this.lblDonGia.TabIndex = 5;
            this.lblDonGia.Text = "Đơn giá (VNĐ):";

            this.txtDonGia.Location = new System.Drawing.Point(280, 180);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(150, 23);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.Enter += new System.EventHandler(this.txt_Enter);
            this.txtDonGia.Leave += new System.EventHandler(this.txtDonGia_Leave);

            // ===== lblThanhTien / txtThanhTien (chỉ hiển thị) =====
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(20, 218);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(105, 15);
            this.lblThanhTien.TabIndex = 6;
            this.lblThanhTien.Text = "Thành tiền (VNĐ):";

            this.txtThanhTien.BackColor = System.Drawing.SystemColors.Control;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtThanhTien.Location = new System.Drawing.Point(280, 215);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(150, 23);
            this.txtThanhTien.TabStop = false;

            // ===== btnThemDong =====
            this.btnThemDong.Location = new System.Drawing.Point(280, 250);
            this.btnThemDong.Name = "btnThemDong";
            this.btnThemDong.Size = new System.Drawing.Size(190, 30);
            this.btnThemDong.TabIndex = 3;
            this.btnThemDong.Text = "Thêm vào hóa đơn (Enter)";
            this.btnThemDong.UseVisualStyleBackColor = true;
            this.btnThemDong.Click += new System.EventHandler(this.btnThemDong_Click);

            // ===== lstHoaDon =====
            this.lstHoaDon.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstHoaDon.FormattingEnabled = true;
            this.lstHoaDon.ItemHeight = 15;
            this.lstHoaDon.Location = new System.Drawing.Point(20, 295);
            this.lstHoaDon.Name = "lstHoaDon";
            this.lstHoaDon.Size = new System.Drawing.Size(560, 139);
            this.lstHoaDon.TabIndex = 4;
            this.lstHoaDon.TabStop = false; // không nằm trong luồng Tab/Enter nhập liệu

            // ===== lblTongTien =====
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.Location = new System.Drawing.Point(20, 445);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(160, 20);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "Tổng cộng: 0 VNĐ";

            // ===== btnThanhToan =====
            this.btnThanhToan.Location = new System.Drawing.Point(450, 440);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(130, 35);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            // ===== lblActiveControl (thanh trạng thái demo Focus) =====
            this.lblActiveControl.AutoSize = true;
            this.lblActiveControl.ForeColor = System.Drawing.Color.DimGray;
            this.lblActiveControl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblActiveControl.Location = new System.Drawing.Point(20, 485);
            this.lblActiveControl.Name = "lblActiveControl";
            this.lblActiveControl.Size = new System.Drawing.Size(300, 15);
            this.lblActiveControl.TabIndex = 8;
            this.lblActiveControl.Text = "Chưa có control nào đang active";

            // ===== FormLapHoaDon =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 520);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMauSP);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.btnThemDong);
            this.Controls.Add(this.lstHoaDon);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblActiveControl);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Hóa Đơn Bán Hàng - Cửa hàng Điện máy XYZ";

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMauSP;

        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;

        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;

        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;

        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;

        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;

        private System.Windows.Forms.Button btnThemDong;
        private System.Windows.Forms.ListBox lstHoaDon;

        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThanhToan;

        private System.Windows.Forms.Label lblActiveControl;
    }
}
