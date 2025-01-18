namespace LyTool
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxAuthor;
        private System.Windows.Forms.TextBox txtAuthorDescription;
        private System.Windows.Forms.LinkLabel linkAuthor;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

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
            this.pictureBoxAuthor = new System.Windows.Forms.PictureBox();
            this.txtAuthorDescription = new System.Windows.Forms.TextBox();
            this.linkAuthor = new System.Windows.Forms.LinkLabel();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthor)).BeginInit();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAuthor
            // 
            this.pictureBoxAuthor.Location = new System.Drawing.Point(30, 20);
            this.pictureBoxAuthor.Name = "pictureBoxAuthor";
            this.pictureBoxAuthor.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAuthor.TabIndex = 0;
            this.pictureBoxAuthor.TabStop = false;
            // Đặt ảnh tác giả từ đường dẫn tương đối an toàn
            this.pictureBoxAuthor.Image = System.Drawing.Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "img", "lytran.jpg"));
            // 
            // txtAuthorDescription
            // 
            this.txtAuthorDescription.Location = new System.Drawing.Point(200, 20);
            this.txtAuthorDescription.Multiline = true;
            this.txtAuthorDescription.Name = "txtAuthorDescription";
            this.txtAuthorDescription.ReadOnly = true;
            this.txtAuthorDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAuthorDescription.Size = new System.Drawing.Size(280, 100);
            this.txtAuthorDescription.TabIndex = 1;
            this.txtAuthorDescription.Text = "Chúng tôi cung cấp dịch vụ thiết kế website chuẩn SEO, code dự án ứng dụng...\r\n \r\nTài khoản để sử dụng phần mềm:\r\n- User: lytran\r\n- Password: 16051998";
            // 
            // linkAuthor
            // 
            this.linkAuthor.AutoSize = true;
            this.linkAuthor.Location = new System.Drawing.Point(200, 130);
            this.linkAuthor.Name = "linkAuthor";
            this.linkAuthor.Size = new System.Drawing.Size(180, 20);
            this.linkAuthor.TabIndex = 2;
            this.linkAuthor.TabStop = true;
            this.linkAuthor.Text = "Liên hệ Zalo";
            this.linkAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAuthor_LinkClicked);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Location = new System.Drawing.Point(30, 190);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(450, 140);
            this.grpLogin.TabIndex = 3;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Đăng nhập";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên đăng nhập:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(140, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(280, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(140, 105);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.linkAuthor);
            this.Controls.Add(this.txtAuthorDescription);
            this.Controls.Add(this.pictureBoxAuthor);
            this.Name = "Form1";
            this.Text = "Quay Màn Hình";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthor)).EndInit();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
