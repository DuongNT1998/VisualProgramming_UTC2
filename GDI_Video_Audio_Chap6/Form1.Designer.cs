namespace GDI_Video_Audio_Chap6
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
            this.grpWav = new System.Windows.Forms.GroupBox();
            this.txtWav = new System.Windows.Forms.TextBox();
            this.btnBrowseWav = new System.Windows.Forms.Button();
            this.btnWavPlay = new System.Windows.Forms.Button();
            this.btnWavLoop = new System.Windows.Forms.Button();
            this.btnWavStop = new System.Windows.Forms.Button();
            this.grpMci = new System.Windows.Forms.GroupBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.btnBrowseMedia = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.trkPos = new System.Windows.Forms.TrackBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpWav.SuspendLayout();
            this.grpMci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpWav
            // 
            this.grpWav.Controls.Add(this.txtWav);
            this.grpWav.Controls.Add(this.btnBrowseWav);
            this.grpWav.Controls.Add(this.btnWavPlay);
            this.grpWav.Controls.Add(this.btnWavLoop);
            this.grpWav.Controls.Add(this.btnWavStop);
            this.grpWav.Location = new System.Drawing.Point(12, 12);
            this.grpWav.Name = "grpWav";
            this.grpWav.Size = new System.Drawing.Size(460, 118);
            this.grpWav.TabStop = false;
            this.grpWav.Text = "1. SoundPlayer - Chuông báo gọi món (chỉ file .wav)";
            // 
            // txtWav
            // 
            this.txtWav.Location = new System.Drawing.Point(14, 28);
            this.txtWav.Name = "txtWav";
            this.txtWav.ReadOnly = true;
            this.txtWav.Size = new System.Drawing.Size(340, 23);
            // 
            // btnBrowseWav
            // 
            this.btnBrowseWav.Location = new System.Drawing.Point(362, 27);
            this.btnBrowseWav.Name = "btnBrowseWav";
            this.btnBrowseWav.Size = new System.Drawing.Size(84, 25);
            this.btnBrowseWav.Text = "Chọn...";
            this.btnBrowseWav.Click += new System.EventHandler(this.btnBrowseWav_Click);
            // 
            // btnWavPlay
            // 
            this.btnWavPlay.Location = new System.Drawing.Point(14, 68);
            this.btnWavPlay.Name = "btnWavPlay";
            this.btnWavPlay.Size = new System.Drawing.Size(140, 32);
            this.btnWavPlay.Text = "Phát 1 lần (Play)";
            this.btnWavPlay.Click += new System.EventHandler(this.btnWavPlay_Click);
            // 
            // btnWavLoop
            // 
            this.btnWavLoop.Location = new System.Drawing.Point(164, 68);
            this.btnWavLoop.Name = "btnWavLoop";
            this.btnWavLoop.Size = new System.Drawing.Size(140, 32);
            this.btnWavLoop.Text = "Phát lặp (PlayLooping)";
            this.btnWavLoop.Click += new System.EventHandler(this.btnWavLoop_Click);
            // 
            // btnWavStop
            // 
            this.btnWavStop.Location = new System.Drawing.Point(314, 68);
            this.btnWavStop.Name = "btnWavStop";
            this.btnWavStop.Size = new System.Drawing.Size(132, 32);
            this.btnWavStop.Text = "Dừng (Stop)";
            this.btnWavStop.Click += new System.EventHandler(this.btnWavStop_Click);
            // 
            // grpMci
            // 
            this.grpMci.Controls.Add(this.txtMedia);
            this.grpMci.Controls.Add(this.btnBrowseMedia);
            this.grpMci.Controls.Add(this.btnPlay);
            this.grpMci.Controls.Add(this.btnPause);
            this.grpMci.Controls.Add(this.btnStop);
            this.grpMci.Controls.Add(this.trkPos);
            this.grpMci.Controls.Add(this.lblTime);
            this.grpMci.Controls.Add(this.lblStatus);
            this.grpMci.Location = new System.Drawing.Point(12, 140);
            this.grpMci.Name = "grpMci";
            this.grpMci.Size = new System.Drawing.Size(460, 212);
            this.grpMci.TabStop = false;
            this.grpMci.Text = "2. MCI (winmm.dll) - Nhạc nền quán (mp3, wav, wma...)";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(14, 28);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(340, 23);
            // 
            // btnBrowseMedia
            // 
            this.btnBrowseMedia.Location = new System.Drawing.Point(362, 27);
            this.btnBrowseMedia.Name = "btnBrowseMedia";
            this.btnBrowseMedia.Size = new System.Drawing.Size(84, 25);
            this.btnBrowseMedia.Text = "Mở file...";
            this.btnBrowseMedia.Click += new System.EventHandler(this.btnBrowseMedia_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(14, 68);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(140, 32);
            this.btnPlay.Text = "Phát (play)";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(164, 68);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(140, 32);
            this.btnPause.Text = "Tạm dừng (pause)";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(314, 68);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(132, 32);
            this.btnStop.Text = "Dừng (stop)";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // trkPos
            // 
            this.trkPos.Location = new System.Drawing.Point(14, 116);
            this.trkPos.Maximum = 1;
            this.trkPos.Name = "trkPos";
            this.trkPos.Size = new System.Drawing.Size(432, 45);
            this.trkPos.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkPos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trkPos_MouseDown);
            this.trkPos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trkPos_MouseUp);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(14, 168);
            this.lblTime.Name = "lblTime";
            this.lblTime.Text = "00:00 / 00:00";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(14, 188);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Trạng thái: chưa mở file";
            // 
            // lblNote
            // 
            this.lblNote.ForeColor = System.Drawing.Color.DimGray;
            this.lblNote.Location = new System.Drawing.Point(12, 360);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(460, 50);
            this.lblNote.Text = "Ghi chú: SoundPlayer chỉ phát .wav (PCM) và không có Pause. " +
                "MCI phát được nhiều định dạng hơn, có Pause / Seek / đọc vị trí phát.";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 416);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.grpMci);
            this.Controls.Add(this.grpWav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương 6 - Xử lý âm thanh: Quán cà phê (nhạc nền & chuông báo)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grpWav.ResumeLayout(false);
            this.grpWav.PerformLayout();
            this.grpMci.ResumeLayout(false);
            this.grpMci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox grpWav;
        private System.Windows.Forms.TextBox txtWav;
        private System.Windows.Forms.Button btnBrowseWav;
        private System.Windows.Forms.Button btnWavPlay;
        private System.Windows.Forms.Button btnWavLoop;
        private System.Windows.Forms.Button btnWavStop;
        private System.Windows.Forms.GroupBox grpMci;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button btnBrowseMedia;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trkPos;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Timer timer1;
    }
}
