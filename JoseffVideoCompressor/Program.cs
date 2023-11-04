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

            IPathValidator pathValidator = new PathValidator();
            ISettingManager settings = new SettingManager();
            IFfmpeg ffmpeg = new Ffmpeg(settings, pathValidator);

            if(!ffmpeg.CurrentFfmpegPathValid)
                Application.Run(new GetFfmpegLocation(settings, pathValidator));
            Application.Run(new Form1(settings, ffmpeg));
        }
    }
}
