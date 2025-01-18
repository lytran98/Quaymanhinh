namespace LyTool
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnClose;

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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(20, 20);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(300, 80);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Hướng dẫn sử dụng phím tắt:\r\n- F1: Bắt đầu ghi hình\r\n- F2: Dừng ghi hình\r\n- F3: Tạm dừng\r\n- F4: Tiếp tục\r\n";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(20, 110);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(150, 20);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Ứng dụng ghi hình màn hình được phát triển bởi Lý Trần.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(120, 140);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 190);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblInstructions);
            this.Name = "SettingsForm";
            this.Text = "Thông tin";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
