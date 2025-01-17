using JoseffVideoCompressor.Services;
using JoseffVideoCompressor.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace JoseffVideoCompressor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ISettingManager settings = new SettingManager();
            IFfmpeg ffmpeg = new Ffmpeg(settings);

            Application.Run(new Form1(settings, ffmpeg));
        }
    }
}
