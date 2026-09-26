namespace GDI_FullChapterExample_Chap6
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
            this.pnlCard = new GDI_FullChapterExample_Chap6.BufferedPanel();
            this.lblDc = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblMajor = new System.Windows.Forms.Label();
            this.cboMajor = new System.Windows.Forms.ComboBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkAntiAlias = new System.Windows.Forms.CheckBox();
            this.chkWatermark = new System.Windows.Forms.CheckBox();
            this.lblRotate = new System.Windows.Forms.Label();
            this.trkRotate = new System.Windows.Forms.TrackBar();
            this.lblZoom = new System.Windows.Forms.Label();
            this.trkZoom = new System.Windows.Forms.TrackBar();
            this.grpDevice = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnStamp = new System.Windows.Forms.Button();
            this.lblExport = new System.Windows.Forms.Label();
            this.pbExport = new System.Windows.Forms.PictureBox();
            this.grpData.SuspendLayout();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkZoom)).BeginInit();
            this.grpDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Location = new System.Drawing.Point(12, 12);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(520, 400);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // 
            // lblDc
            // 
            this.lblDc.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblDc.ForeColor = System.Drawing.Color.DimGray;
            this.lblDc.Location = new System.Drawing.Point(12, 418);
            this.lblDc.Name = "lblDc";
            this.lblDc.Size = new System.Drawing.Size(520, 48);
            this.lblDc.TabIndex = 1;
            this.lblDc.Text = "Device Context: ...";
            // 
            // lstLog
            // 
            this.lstLog.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.IntegralHeight = false;
            this.lstLog.Location = new System.Drawing.Point(12, 470);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(520, 158);
            this.lstLog.TabIndex = 2;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.lblName);
            this.grpData.Controls.Add(this.txtName);
            this.grpData.Controls.Add(this.lblId);
            this.grpData.Controls.Add(this.txtId);
            this.grpData.Controls.Add(this.lblMajor);
            this.grpData.Controls.Add(this.cboMajor);
            this.grpData.Location = new System.Drawing.Point(545, 12);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(443, 120);
            this.grpData.TabIndex = 3;
            this.grpData.TabStop = false;
            this.grpData.Text = "1. Dữ liệu thẻ sinh viên";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 15);
            this.lblName.Text = "Họ tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 23);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Nguyễn Văn An";
            this.txtName.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 59);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 15);
            this.lblId.Text = "MSSV:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(80, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(340, 23);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "2251120001";
            this.txtId.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(14, 89);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(42, 15);
            this.lblMajor.Text = "Ngành:";
            // 
            // cboMajor
            // 
            this.cboMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMajor.Location = new System.Drawing.Point(80, 86);
            this.cboMajor.Name = "cboMajor";
            this.cboMajor.Size = new System.Drawing.Size(340, 23);
            this.cboMajor.TabIndex = 2;
            this.cboMajor.SelectedIndexChanged += new System.EventHandler(this.DataChanged);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkAntiAlias);
            this.grpOptions.Controls.Add(this.chkWatermark);
            this.grpOptions.Controls.Add(this.lblRotate);
            this.grpOptions.Controls.Add(this.trkRotate);
            this.grpOptions.Controls.Add(this.lblZoom);
            this.grpOptions.Controls.Add(this.trkZoom);
            this.grpOptions.Location = new System.Drawing.Point(545, 138);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(443, 160);
            this.grpOptions.TabIndex = 4;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "2. Đặc tính mới của GDI+";
            // 
            // chkAntiAlias
            // 
            this.chkAntiAlias.Checked = true;
            this.chkAntiAlias.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAntiAlias.Location = new System.Drawing.Point(14, 22);
            this.chkAntiAlias.Name = "chkAntiAlias";
            this.chkAntiAlias.Size = new System.Drawing.Size(410, 22);
            this.chkAntiAlias.Text = "Làm mịn lề - Antialiasing (SmoothingMode.AntiAlias)";
            this.chkAntiAlias.CheckedChanged += new System.EventHandler(this.DataChanged);
            // 
            // chkWatermark
            // 
            this.chkWatermark.Checked = true;
            this.chkWatermark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWatermark.Location = new System.Drawing.Point(14, 46);
            this.chkWatermark.Name = "chkWatermark";
            this.chkWatermark.Size = new System.Drawing.Size(410, 22);
            this.chkWatermark.Text = "Watermark trong suốt - Alpha Blending (Color.FromArgb)";
            this.chkWatermark.CheckedChanged += new System.EventHandler(this.DataChanged);
            // 
            // lblRotate
            // 
            this.lblRotate.AutoSize = true;
            this.lblRotate.Location = new System.Drawing.Point(14, 86);
            this.lblRotate.Name = "lblRotate";
            this.lblRotate.Text = "Xoay: 0°";
            // 
            // trkRotate
            // 
            this.trkRotate.LargeChange = 15;
            this.trkRotate.Location = new System.Drawing.Point(100, 78);
            this.trkRotate.Maximum = 180;
            this.trkRotate.Minimum = -180;
            this.trkRotate.Name = "trkRotate";
            this.trkRotate.Size = new System.Drawing.Size(330, 45);
            this.trkRotate.TickFrequency = 45;
            this.trkRotate.ValueChanged += new System.EventHandler(this.DataChanged);
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(14, 124);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Text = "Phóng: 100%";
            // 
            // trkZoom
            // 
            this.trkZoom.LargeChange = 10;
            this.trkZoom.Location = new System.Drawing.Point(100, 116);
            this.trkZoom.Maximum = 150;
            this.trkZoom.Minimum = 50;
            this.trkZoom.Name = "trkZoom";
            this.trkZoom.Size = new System.Drawing.Size(330, 45);
            this.trkZoom.TickFrequency = 10;
            this.trkZoom.Value = 100;
            this.trkZoom.ValueChanged += new System.EventHandler(this.DataChanged);
            // 
            // grpDevice
            // 
            this.grpDevice.Controls.Add(this.btnExport);
            this.grpDevice.Controls.Add(this.btnSave);
            this.grpDevice.Controls.Add(this.btnPreview);
            this.grpDevice.Controls.Add(this.btnStamp);
            this.grpDevice.Location = new System.Drawing.Point(545, 304);
            this.grpDevice.Name = "grpDevice";
            this.grpDevice.Size = new System.Drawing.Size(443, 102);
            this.grpDevice.TabIndex = 5;
            this.grpDevice.TabStop = false;
            this.grpDevice.Text = "3. Cùng 1 hàm vẽ - nhiều thiết bị (Device Context)";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(14, 24);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(205, 32);
            this.btnExport.Text = "→ Bitmap (FromImage)";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(226, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 32);
            this.btnSave.Text = "Lưu ảnh PNG...";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(14, 62);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(205, 32);
            this.btnPreview.Text = "→ Máy in (PrintPreview)";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnStamp
            // 
            this.btnStamp.Location = new System.Drawing.Point(226, 62);
            this.btnStamp.Name = "btnStamp";
            this.btnStamp.Size = new System.Drawing.Size(205, 32);
            this.btnStamp.Text = "→ CreateGraphics (đóng dấu)";
            this.btnStamp.Click += new System.EventHandler(this.btnStamp_Click);
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Location = new System.Drawing.Point(545, 412);
            this.lblExport.Name = "lblExport";
            this.lblExport.Text = "Kết quả Bitmap xuất ra (3x, nền trong suốt):";
            // 
            // pbExport
            // 
            this.pbExport.BackColor = System.Drawing.Color.Gainsboro;
            this.pbExport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExport.Location = new System.Drawing.Point(545, 432);
            this.pbExport.Name = "pbExport";
            this.pbExport.Size = new System.Drawing.Size(443, 196);
            this.pbExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExport.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.pbExport);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.grpDevice);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.lblDc);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương 6 - GDI+: Kiến trúc & Device Context | Demo Thẻ sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkZoom)).EndInit();
            this.grpDevice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private BufferedPanel pnlCard;
        private System.Windows.Forms.Label lblDc;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.ComboBox cboMajor;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkAntiAlias;
        private System.Windows.Forms.CheckBox chkWatermark;
        private System.Windows.Forms.Label lblRotate;
        private System.Windows.Forms.TrackBar trkRotate;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.TrackBar trkZoom;
        private System.Windows.Forms.GroupBox grpDevice;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnStamp;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.PictureBox pbExport;
    }
}
