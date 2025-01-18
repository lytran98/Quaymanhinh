namespace LyTool
{
    partial class ControlPanelForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Button btnPauseRecording;
        private System.Windows.Forms.Button btnResumeRecording;
        private System.Windows.Forms.Button btnStopRecording;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSettings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.btnPauseRecording = new System.Windows.Forms.Button();
            this.btnResumeRecording = new System.Windows.Forms.Button();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnStartRecording
            this.btnStartRecording.Text = "Bắt đầu";
            this.btnStartRecording.Size = new System.Drawing.Size(150, 30);
            this.btnStartRecording.Location = new System.Drawing.Point(20, 30);
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);

            // btnPauseRecording
            this.btnPauseRecording.Text = "Tạm dừng";
            this.btnPauseRecording.Size = new System.Drawing.Size(150, 30);
            this.btnPauseRecording.Location = new System.Drawing.Point(20, 70);
            this.btnPauseRecording.Visible = false;
            this.btnPauseRecording.Click += new System.EventHandler(this.btnPauseRecording_Click);

            // btnResumeRecording
            this.btnResumeRecording.Text = "Tiếp tục";
            this.btnResumeRecording.Size = new System.Drawing.Size(150, 30);
            this.btnResumeRecording.Location = new System.Drawing.Point(20, 110);
            this.btnResumeRecording.Visible = false;
            this.btnResumeRecording.Click += new System.EventHandler(this.btnResumeRecording_Click);

            // btnStopRecording
            this.btnStopRecording.Text = "Lưu";
            this.btnStopRecording.Size = new System.Drawing.Size(150, 30);
            this.btnStopRecording.Location = new System.Drawing.Point(20, 150);
            this.btnStopRecording.Visible = false;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);

            // lblStatus
            this.lblStatus.Text = "Trạng thái: Chờ hành động.";
            this.lblStatus.Size = new System.Drawing.Size(260, 30);
            this.lblStatus.Location = new System.Drawing.Point(20, 200);

            // btnSettings
            this.btnSettings.Text = "❓";
            this.btnSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSettings.Location = new System.Drawing.Point(260, 10);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);

            // ControlPanelForm
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnStartRecording);
            this.Controls.Add(this.btnPauseRecording);
            this.Controls.Add(this.btnResumeRecording);
            this.Controls.Add(this.btnStopRecording);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSettings);
            this.Name = "ControlPanelForm";
            this.Text = "Quay Màn Hình";
            this.ResumeLayout(false);
        }
    }
}
