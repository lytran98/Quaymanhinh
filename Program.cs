using System;
using System.Windows.Forms;

namespace LyTool
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // Đối với .NET 6 trở lên. Với .NET Framework, sử dụng Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
