using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LyTool
{
    public partial class Form1 : Form
    {
        // Thông tin đăng nhập hợp lệ
        private const string validUsername = "lytran";
        private const string validPassword = "16051998";

        public Form1()
        {
            InitializeComponent();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy thông tin người dùng nhập
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Kiểm tra thông tin đăng nhập
            if (username.Equals(validUsername, StringComparison.OrdinalIgnoreCase) && password == validPassword)
            {
                // Đăng nhập thành công, mở ControlPanelForm
                ControlPanelForm controlPanel = new ControlPanelForm();
                controlPanel.Show();

                // Đóng hoặc ẩn form đăng nhập
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở liên kết tác giả trong trình duyệt mặc định
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://zalo.me/+84876437046",
                UseShellExecute = true
            });
        }
    }
}
