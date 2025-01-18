using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LyTool
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            // Đặt biểu tượng cho Form từ đường dẫn icon tương đối
            string iconPath = Path.Combine(Application.StartupPath, "img", "icon.ico");
            if (File.Exists(iconPath))
            {
                this.Icon = new Icon(iconPath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file icon!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
