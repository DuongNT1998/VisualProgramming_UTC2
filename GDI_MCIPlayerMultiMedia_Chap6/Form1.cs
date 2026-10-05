using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace GDI_MCIPlayerMultiMedia_Chap6
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string command, string returnString, int returnLength, IntPtr winHandle);

        private Button btnOpen, btnPlay, btnPause, btnResume, btnStop;
        private Label lblTime;
        private TrackBar trackBar;
        private System.Windows.Forms.Timer  timer;
        private string filePath = "";
        private bool isPlaying = false;
        public Form1()
        {
            InitializeComponent();

            btnOpen = new Button() { Text = "Open", Left = 30, Top = 30, Width = 80 };
            btnPlay = new Button() { Text = "Play", Left = 30, Top = 70, Width = 80 };
            btnPause = new Button() { Text = "Pause", Left = 120, Top = 70, Width = 80 };
            btnResume = new Button() { Text = "Resume", Left = 210, Top = 70, Width = 80 };
            btnStop = new Button() { Text = "Stop", Left = 300, Top = 70, Width = 80 };

            lblTime = new Label() { Text = "00:00", Left = 30, Top = 120, Width = 100 };
            trackBar = new TrackBar() { Left = 30, Top = 150, Width = 320, Minimum = 0 };

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500; // Update every 0.5s
            timer.Tick += Timer_Tick;

            btnOpen.Click += (s, e) => OpenFile();
            btnPlay.Click += (s, e) => Play();
            btnPause.Click += (s, e) => Pause();
            btnResume.Click += (s, e) => Resume();
            btnStop.Click += (s, e) => Stop();

            this.Controls.AddRange(new Control[] { btnOpen, btnPlay, btnPause, btnResume, btnStop, lblTime, trackBar });
        }
        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 Files|*.mp3|WAV Files|*.wav|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                Stop();
                mciSendString("open \"" + filePath + "\" type mpegvideo alias mymusic", null, 0, IntPtr.Zero);

                string lengthStr = new string('\0', 128);
                mciSendString("status mymusic length", lengthStr, lengthStr.Length, IntPtr.Zero);
                int lengthMs = int.TryParse(lengthStr.Trim(), out int len) ? len : 0;
                trackBar.Maximum = lengthMs;
            }
        }

        private void Play()
        {
            if (filePath == "") return;
            mciSendString("play mymusic", null, 0, IntPtr.Zero);
            isPlaying = true;
            timer.Start();
        }

        private void Pause()
        {
            mciSendString("pause mymusic", null, 0, IntPtr.Zero);
            isPlaying = false;
        }

        private void Resume()
        {
            mciSendString("resume mymusic", null, 0, IntPtr.Zero);
            isPlaying = true;
        }

        private void Stop()
        {
            mciSendString("stop mymusic", null, 0, IntPtr.Zero);
            mciSendString("close mymusic", null, 0, IntPtr.Zero);
            isPlaying = false;
            timer.Stop();
            trackBar.Value = 0;
            lblTime.Text = "00:00";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!isPlaying) return;

            string posStr = new string('\0', 128);
            mciSendString("status mymusic position", posStr, posStr.Length, IntPtr.Zero);
            if (int.TryParse(posStr.Trim(), out int posMs))
            {
                trackBar.Value = Math.Min(posMs, trackBar.Maximum);
                lblTime.Text = TimeSpan.FromMilliseconds(posMs).ToString(@"mm\:ss");
            }
        }

    }
}
