using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ScreenRecorderLib;

namespace LyTool
{
    public partial class ControlPanelForm : Form
    {
        private Recorder? _recorder;
        private bool isRecording = false;
        private bool isPaused = false;

        public ControlPanelForm()
        {
            InitializeComponent();
            UpdateButtonLayout();
            // Đặt biểu tượng cho Form từ đường dẫn icon tương đối
            string iconPath = Path.Combine(Application.StartupPath, "img", "screen.ico");
            if (File.Exists(iconPath))
            {
                this.Icon = new Icon(iconPath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file icon!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xử lý phím tắt
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1 && !isRecording)
            {
                btnStartRecording.PerformClick();
                return true;
            }
            if (keyData == Keys.F2 && isRecording)
            {
                btnStopRecording.PerformClick();
                return true;
            }
            if (keyData == Keys.F3 && isRecording && !isPaused)
            {
                btnPauseRecording.PerformClick();
                return true;
            }
            if (keyData == Keys.F4 && isRecording && isPaused)
            {
                btnResumeRecording.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void StartVideoRecording(string filePath)
        {
            _recorder = Recorder.CreateRecorder(new RecorderOptions
            {
                AudioOptions = new AudioOptions
                {
                    IsAudioEnabled = true
                }
            });

            _recorder.OnRecordingComplete += (s, e) =>
            {
                lblStatus.Text = $"Ghi hình hoàn tất: {e.FilePath}";
                ResetButtons();
            };

            _recorder.OnRecordingFailed += (s, e) =>
            {
                lblStatus.Text = $"Lỗi: {e.Error}";
                ResetButtons();
            };

            _recorder.Record(filePath);
        }

        private void ResetButtons()
        {
            isRecording = false;
            isPaused = false;

            btnStartRecording.Visible = true;
            btnPauseRecording.Visible = false;
            btnResumeRecording.Visible = false;
            btnStopRecording.Visible = false;

            lblStatus.Text = "Trạng thái: Chờ hành động.";
            UpdateButtonLayout();
        }

        private void UpdateButtonLayout()
        {
            int baseY = 30;
            int offset = 10;
            int currentY = baseY;

            if (btnStartRecording.Visible)
            {
                btnStartRecording.Location = new Point(20, currentY);
                currentY += btnStartRecording.Height + offset;
            }

            if (btnPauseRecording.Visible)
            {
                btnPauseRecording.Location = new Point(20, currentY);
                currentY += btnPauseRecording.Height + offset;
            }

            if (btnResumeRecording.Visible)
            {
                btnResumeRecording.Location = new Point(20, currentY);
                currentY += btnResumeRecording.Height + offset;
            }

            if (btnStopRecording.Visible)
            {
                btnStopRecording.Location = new Point(20, currentY);
                currentY += btnStopRecording.Height + offset;
            }

            lblStatus.Location = new Point(20, currentY + offset);
            this.ClientSize = new Size(300, lblStatus.Location.Y + lblStatus.Height + 20);
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "MP4 files (*.mp4)|*.mp4",
                Title = "Chọn nơi lưu video"
            })
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    StartVideoRecording(saveDialog.FileName);
                    isRecording = true;
                    lblStatus.Text = "Đang ghi hình...";
                    btnStartRecording.Visible = false;
                    btnPauseRecording.Visible = true;
                    btnStopRecording.Visible = true;
                    UpdateButtonLayout();
                }
            }
        }

        private void btnPauseRecording_Click(object sender, EventArgs e)
        {
            _recorder?.Pause();
            isPaused = true;
            lblStatus.Text = "Ghi hình đã tạm dừng.";
            btnPauseRecording.Visible = false;
            btnResumeRecording.Visible = true;
            UpdateButtonLayout();
        }

        private void btnResumeRecording_Click(object sender, EventArgs e)
        {
            _recorder?.Resume();
            isPaused = false;
            lblStatus.Text = "Tiếp tục ghi hình.";
            btnResumeRecording.Visible = false;
            btnPauseRecording.Visible = true;
            UpdateButtonLayout();
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            _recorder?.Stop();
            lblStatus.Text = "Ghi hình đã dừng.";
            ResetButtons();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}
