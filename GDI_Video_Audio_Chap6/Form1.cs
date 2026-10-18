using System.Media;
using System.Runtime.InteropServices;
using System.Text;
namespace GDI_Video_Audio_Chap6
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll", CharSet = CharSet.Unicode)]
        private static extern int mciSendString(string command, StringBuilder? returnValue,
                                              int returnLength, IntPtr hwndCallback);

        private readonly SoundPlayer _player = new();   // PHẦN 1: dùng cho file .wav
        private bool _mediaOpen = false;                // đã "open" file MCI chưa?
        private int _length = 0;                        // độ dài bài hát (mili giây)
        private bool _dragging = false;                 // đang kéo thanh trượt?
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBrowseWav_Click(object? sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog { Filter = "WAV file|*.wav" };
            if (dlg.ShowDialog() == DialogResult.OK)
                txtWav.Text = dlg.FileName;
        }

        private void btnWavPlay_Click(object? sender, EventArgs e)
        {
            if (!PrepareWav()) return;
            _player.Play();          // phát 1 lần (không chặn giao diện)
        }

        private void btnWavLoop_Click(object? sender, EventArgs e)
        {
            if (!PrepareWav()) return;
            _player.PlayLooping();   // phát lặp đi lặp lại
        }

        private void btnWavStop_Click(object? sender, EventArgs e)
        {
            _player.Stop();
        }

        // Gán đường dẫn cho SoundPlayer và nạp file; báo lỗi nếu file không hợp lệ
        private bool PrepareWav()
        {
            if (string.IsNullOrEmpty(txtWav.Text))
            {
                MessageBox.Show("Hãy chọn file .wav trước.");
                return false;
            }
            try
            {
                _player.SoundLocation = txtWav.Text;
                _player.Load();
                return true;
            }
            catch (Exception ex)   // file không tồn tại hoặc không phải wav chuẩn
            {
                MessageBox.Show("Không phát được: " + ex.Message);
                return false;
            }
        }




        private void btnBrowseMedia_Click(object? sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Filter = "Media|*.mp3;*.wav;*.wma;*.mid|Tất cả|*.*"
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            CloseMedia();                                   // đóng bài cũ (nếu có)
            txtMedia.Text = dlg.FileName;

            // "open" file và đặt bí danh (alias) MediaFile để các lệnh sau gọi tên ngắn
            int err = mciSendString($"open \"{dlg.FileName}\" type mpegvideo alias MediaFile",
                                    null, 0, IntPtr.Zero);
            if (err != 0)
            {
                MessageBox.Show("Không mở được file (mã lỗi MCI: " + err + ")");
                return;
            }

            mciSendString("set MediaFile time format milliseconds", null, 0, IntPtr.Zero);
            _length = int.TryParse(MciStatus("length"), out int len) ? len : 0;
            trkPos.Maximum = Math.Max(_length, 1);
            _mediaOpen = true;
            timer1.Start();
        }

        private void btnPlay_Click(object? sender, EventArgs e)
        {
            if (!_mediaOpen) { MessageBox.Show("Hãy mở file nhạc trước."); return; }
            // "play" vừa dùng để phát lần đầu, vừa để phát tiếp sau khi pause
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void btnPause_Click(object? sender, EventArgs e)
        {
            if (!_mediaOpen) return;
            mciSendString("pause MediaFile", null, 0, IntPtr.Zero);
        }

        private void btnStop_Click(object? sender, EventArgs e)
        {
            if (!_mediaOpen) return;
            mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
            mciSendString("seek MediaFile to start", null, 0, IntPtr.Zero);  // tua về đầu bài
        }

        // Đọc thông tin từ MCI: "position" (vị trí), "length" (độ dài), "mode" (playing/paused/stopped)
        private static string MciStatus(string what)
        {
            var sb = new StringBuilder(128);
            mciSendString($"status MediaFile {what}", sb, sb.Capacity, IntPtr.Zero);
            return sb.ToString();
        }

        private void CloseMedia()
        {
            if (!_mediaOpen) return;
            timer1.Stop();
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            _mediaOpen = false;
            trkPos.Value = 0;
            lblTime.Text = "00:00 / 00:00";
            lblStatus.Text = "Trạng thái: chưa mở file";
        }

        // Timer 300ms: cập nhật thanh tiến trình, thời gian và trạng thái
        private void timer1_Tick(object? sender, EventArgs e)
        {
            if (!_mediaOpen) return;
            int pos = int.TryParse(MciStatus("position"), out int p) ? p : 0;

            if (!_dragging)
                trkPos.Value = Math.Min(pos, trkPos.Maximum);

            lblTime.Text = $"{Fmt(pos)} / {Fmt(_length)}";
            lblStatus.Text = "Trạng thái: " + MciStatus("mode");
        }

        // Kéo thanh trượt để tua: dùng lệnh "seek ... to <mili giây>"
        private void trkPos_MouseDown(object? sender, MouseEventArgs e) => _dragging = true;

        private void trkPos_MouseUp(object? sender, MouseEventArgs e)
        {
            _dragging = false;
            if (!_mediaOpen) return;

            bool wasPlaying = MciStatus("mode") == "playing";
            mciSendString($"seek MediaFile to {trkPos.Value}", null, 0, IntPtr.Zero);
            if (wasPlaying)
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);  // seek xong phải play lại
        }

        private static string Fmt(int ms) => TimeSpan.FromMilliseconds(ms).ToString(@"mm\:ss");

        // Đóng form: nhớ giải phóng tài nguyên âm thanh
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            _player.Stop();
            _player.Dispose();
            CloseMedia();
        }
    }
}
