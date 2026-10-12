namespace MessageBox_Custom_Dialog_Form
{
    partial class Formthanhtoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstHoaDon = new System.Windows.Forms.ListBox();
            this.lblTongTien = new System.Windows.Forms.Label();

            this.lblKhachHang = new System.Windows.Forms.Label();
            this.txtKhachHangDaChon = new System.Windows.Forms.TextBox();
            this.btnChonKhachHang = new System.Windows.Forms.Button();

            this.chkMoPhongLoi = new System.Windows.Forms.CheckBox();

            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyGiaoDich = new System.Windows.Forms.Button();

            this.lblGhiChu = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // ===== lblTitle =====
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THANH TOÁN HÓA ĐƠN - QUẦY THU NGÂN";

            // ===== lstHoaDon =====
            this.lstHoaDon.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstHoaDon.FormattingEnabled = true;
            this.lstHoaDon.ItemHeight = 15;
            this.lstHoaDon.Location = new System.Drawing.Point(20, 55);
            this.lstHoaDon.Name = "lstHoaDon";
            this.lstHoaDon.Size = new System.Drawing.Size(560, 139);
            this.lstHoaDon.TabIndex = 1;
            this.lstHoaDon.TabStop = false;

            // ===== lblTongTien =====
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.Location = new System.Drawing.Point(20, 205);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(160, 20);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng cộng: 0 VNĐ";

            // ===== lblKhachHang / txtKhachHangDaChon / btnChonKhachHang =====
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(20, 248);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(80, 15);
            this.lblKhachHang.TabIndex = 3;
            this.lblKhachHang.Text = "Khách hàng:";

            this.txtKhachHangDaChon.BackColor = System.Drawing.SystemColors.Control;
            this.txtKhachHangDaChon.Location = new System.Drawing.Point(120, 245);
            this.txtKhachHangDaChon.Name = "txtKhachHangDaChon";
            this.txtKhachHangDaChon.ReadOnly = true;
            this.txtKhachHangDaChon.Size = new System.Drawing.Size(300, 23);
            this.txtKhachHangDaChon.TabIndex = 4;
            this.txtKhachHangDaChon.TabStop = false;
            this.txtKhachHangDaChon.Text = "-- Chưa chọn khách hàng --";

            this.btnChonKhachHang.Location = new System.Drawing.Point(440, 244);
            this.btnChonKhachHang.Name = "btnChonKhachHang";
            this.btnChonKhachHang.Size = new System.Drawing.Size(140, 25);
            this.btnChonKhachHang.TabIndex = 5;
            this.btnChonKhachHang.Text = "Chọn khách hàng...";
            this.btnChonKhachHang.UseVisualStyleBackColor = true;
            this.btnChonKhachHang.Click += new System.EventHandler(this.btnChonKhachHang_Click);

            // ===== chkMoPhongLoi =====
            this.chkMoPhongLoi.AutoSize = true;
            this.chkMoPhongLoi.ForeColor = System.Drawing.Color.DarkRed;
            this.chkMoPhongLoi.Location = new System.Drawing.Point(20, 288);
            this.chkMoPhongLoi.Name = "chkMoPhongLoi";
            this.chkMoPhongLoi.Size = new System.Drawing.Size(330, 19);
            this.chkMoPhongLoi.TabIndex = 6;
            this.chkMoPhongLoi.Text = "Mô phỏng lỗi khi thanh toán (demo MessageBoxIcon.Error)";
            this.chkMoPhongLoi.UseVisualStyleBackColor = true;

            // ===== btnThanhToan =====
            this.btnThanhToan.Location = new System.Drawing.Point(20, 330);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(150, 35);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            // ===== btnHuyGiaoDich =====
            this.btnHuyGiaoDich.Location = new System.Drawing.Point(190, 330);
            this.btnHuyGiaoDich.Name = "btnHuyGiaoDich";
            this.btnHuyGiaoDich.Size = new System.Drawing.Size(150, 35);
            this.btnHuyGiaoDich.TabIndex = 8;
            this.btnHuyGiaoDich.Text = "Hủy giao dịch";
            this.btnHuyGiaoDich.UseVisualStyleBackColor = true;
            this.btnHuyGiaoDich.Click += new System.EventHandler(this.btnHuyGiaoDich_Click);

            // ===== lblGhiChu =====
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.ForeColor = System.Drawing.Color.Gray;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblGhiChu.Location = new System.Drawing.Point(20, 385);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(560, 15);
            this.lblGhiChu.TabIndex = 9;
            this.lblGhiChu.Text = "Demo đủ 4 loại MessageBox: Warning (chưa chọn KH) · Question (xác nhận) · Error (mô phỏng) · Information (thành công)";

            // ===== FormThanhToan =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstHoaDon);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.txtKhachHangDaChon);
            this.Controls.Add(this.btnChonKhachHang);
            this.Controls.Add(this.chkMoPhongLoi);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnHuyGiaoDich);
            this.Controls.Add(this.lblGhiChu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán hóa đơn - Cửa hàng Điện máy XYZ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstHoaDon;
        private System.Windows.Forms.Label lblTongTien;

        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TextBox txtKhachHangDaChon;
        private System.Windows.Forms.Button btnChonKhachHang;

        private System.Windows.Forms.CheckBox chkMoPhongLoi;

        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyGiaoDich;

        private System.Windows.Forms.Label lblGhiChu;
    }
}