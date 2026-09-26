namespace DemoBasicWinform
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lbMSSV = new Label();
            lbHoVaTen = new Label();
            lbLop = new Label();
            lbGioiTinh = new Label();
            lbNgaySinh = new Label();
            lbGhiChu = new Label();
            lbNangKhieu = new Label();
            tbMSSV = new TextBox();
            tbHoTen = new TextBox();
            cbLop = new ComboBox();
            rdGTNam = new RadioButton();
            rdGTNu = new RadioButton();
            dtNgaySinh = new DateTimePicker();
            tbGhiChu = new TextBox();
            btnNhapThongTin = new Button();
            clbNangKhieu = new CheckedListBox();
            lblLop = new Label();
            lblGioiTinh = new Label();
            lblNgaySinh = new Label();
            lblNangKhieu = new Label();
            lblGhiChu = new Label();
            panel1 = new Panel();
            lbKetQua = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbMSSV
            // 
            lbMSSV.AutoSize = true;
            lbMSSV.Location = new Point(88, 51);
            lbMSSV.Name = "lbMSSV";
            lbMSSV.Size = new Size(110, 20);
            lbMSSV.TabIndex = 1;
            lbMSSV.Text = "Mã số sinh viên";
            // 
            // lbHoVaTen
            // 
            lbHoVaTen.AutoSize = true;
            lbHoVaTen.Location = new Point(88, 98);
            lbHoVaTen.Name = "lbHoVaTen";
            lbHoVaTen.Size = new Size(76, 20);
            lbHoVaTen.TabIndex = 2;
            lbHoVaTen.Text = "Họ và tên:";
            // 
            // lbLop
            // 
            lbLop.Location = new Point(0, 0);
            lbLop.Name = "lbLop";
            lbLop.Size = new Size(100, 23);
            lbLop.TabIndex = 23;
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.Location = new Point(0, 0);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(100, 23);
            lbGioiTinh.TabIndex = 22;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.Location = new Point(0, 0);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(100, 23);
            lbNgaySinh.TabIndex = 21;
            // 
            // lbGhiChu
            // 
            lbGhiChu.Location = new Point(0, 0);
            lbGhiChu.Name = "lbGhiChu";
            lbGhiChu.Size = new Size(100, 23);
            lbGhiChu.TabIndex = 20;
            // 
            // lbNangKhieu
            // 
            lbNangKhieu.Location = new Point(0, 0);
            lbNangKhieu.Name = "lbNangKhieu";
            lbNangKhieu.Size = new Size(100, 23);
            lbNangKhieu.TabIndex = 19;
            // 
            // tbMSSV
            // 
            tbMSSV.Location = new Point(219, 50);
            tbMSSV.Name = "tbMSSV";
            tbMSSV.Size = new Size(241, 27);
            tbMSSV.TabIndex = 9;
            // 
            // tbHoTen
            // 
            tbHoTen.Location = new Point(219, 91);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(241, 27);
            tbHoTen.TabIndex = 10;
            // 
            // cbLop
            // 
            cbLop.FormattingEnabled = true;
            cbLop.Items.AddRange(new object[] { "ĐTCN K61", "ĐTCN K62", "ĐTCN K63", "ĐTCN K64" });
            cbLop.Location = new Point(220, 134);
            cbLop.Name = "cbLop";
            cbLop.Size = new Size(240, 28);
            cbLop.TabIndex = 11;
            // 
            // rdGTNam
            // 
            rdGTNam.AutoSize = true;
            rdGTNam.Location = new Point(218, 195);
            rdGTNam.Name = "rdGTNam";
            rdGTNam.Size = new Size(62, 24);
            rdGTNam.TabIndex = 12;
            rdGTNam.TabStop = true;
            rdGTNam.Text = "Nam";
            rdGTNam.UseVisualStyleBackColor = true;
            // 
            // rdGTNu
            // 
            rdGTNu.AutoSize = true;
            rdGTNu.Location = new Point(360, 195);
            rdGTNu.Name = "rdGTNu";
            rdGTNu.Size = new Size(50, 24);
            rdGTNu.TabIndex = 13;
            rdGTNu.TabStop = true;
            rdGTNu.Text = "Nữ";
            rdGTNu.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Location = new Point(218, 250);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(250, 27);
            dtNgaySinh.TabIndex = 14;
            // 
            // tbGhiChu
            // 
            tbGhiChu.Location = new Point(214, 471);
            tbGhiChu.Multiline = true;
            tbGhiChu.Name = "tbGhiChu";
            tbGhiChu.ScrollBars = ScrollBars.Vertical;
            tbGhiChu.Size = new Size(241, 80);
            tbGhiChu.TabIndex = 16;
            // 
            // btnNhapThongTin
            // 
            btnNhapThongTin.Location = new Point(166, 597);
            btnNhapThongTin.Name = "btnNhapThongTin";
            btnNhapThongTin.Size = new Size(94, 29);
            btnNhapThongTin.TabIndex = 17;
            btnNhapThongTin.Text = "Nhập thông tin";
            btnNhapThongTin.UseVisualStyleBackColor = true;
            btnNhapThongTin.Click += btnNhapThongTin_Click;
            // 
            // clbNangKhieu
            // 
            clbNangKhieu.FormattingEnabled = true;
            clbNangKhieu.Items.AddRange(new object[] { "Thể thao", "Nghệ thuật", "Game", "Học tập", "Giao tiếp" });
            clbNangKhieu.Location = new Point(215, 323);
            clbNangKhieu.Name = "clbNangKhieu";
            clbNangKhieu.Size = new Size(253, 114);
            clbNangKhieu.TabIndex = 18;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(90, 138);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(34, 20);
            lblLop.TabIndex = 24;
            lblLop.Text = "Lớp";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(90, 199);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(65, 20);
            lblGioiTinh.TabIndex = 25;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(90, 257);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(76, 20);
            lblNgaySinh.TabIndex = 26;
            lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblNangKhieu
            // 
            lblNangKhieu.AutoSize = true;
            lblNangKhieu.Location = new Point(90, 323);
            lblNangKhieu.Name = "lblNangKhieu";
            lblNangKhieu.Size = new Size(84, 20);
            lblNangKhieu.TabIndex = 27;
            lblNangKhieu.Text = "Năng khiếu";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(90, 474);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(58, 20);
            lblGhiChu.TabIndex = 28;
            lblGhiChu.Text = "Ghi chú";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbKetQua);
            panel1.Location = new Point(614, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 378);
            panel1.TabIndex = 29;
            // 
            // lbKetQua
            // 
            lbKetQua.AutoSize = true;
            lbKetQua.Location = new Point(30, 12);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(0, 20);
            lbKetQua.TabIndex = 0;
            lbKetQua.Font = new Font("Arial", 15, FontStyle.Bold); // In đậm
            lbKetQua.ForeColor = Color.Red; // Chữ màu đỏ
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1982, 1055);
            Controls.Add(lblGhiChu);
            Controls.Add(lblNangKhieu);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblLop);
            Controls.Add(clbNangKhieu);
            Controls.Add(btnNhapThongTin);
            Controls.Add(tbGhiChu);
            Controls.Add(dtNgaySinh);
            Controls.Add(rdGTNu);
            Controls.Add(rdGTNam);
            Controls.Add(cbLop);
            Controls.Add(tbHoTen);
            Controls.Add(tbMSSV);
            Controls.Add(lbHoVaTen);
            Controls.Add(lbMSSV);
            Controls.Add(lbGioiTinh);
            Controls.Add(lbLop);
            Controls.Add(lbNgaySinh);
            Controls.Add(lbNangKhieu);
            Controls.Add(lbGhiChu);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMSSV;
        private Label lbHoVaTen;
        private Label lbLop;
        private Label lbGioiTinh;
        private Label lbNgaySinh;
        private Label lbGhiChu;
        private Label lbNangKhieu;
        private TextBox tbMSSV;
        private TextBox tbHoTen;
        private ComboBox cbLop;
        private RadioButton rdGTNam;
        private RadioButton rdGTNu;
        private DateTimePicker dtNgaySinh;
        private TextBox tbGhiChu;
        private Button btnNhapThongTin;
        private CheckedListBox clbNangKhieu;
        private Label lblLop;
        private Label lblGioiTinh;
        private Label lblNgaySinh;
        private Label lblNangKhieu;
        private Label lblGhiChu;
        private Panel panel1;
        private Label lbKetQua;
    }
}