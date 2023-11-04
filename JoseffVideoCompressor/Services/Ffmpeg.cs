using JoseffVideoCompressor.Models;
using JoseffVideoCompressor.Services.Interfaces;
using System;
using System.Diagnostics;
using System.IO;

namespace JoseffVideoCompressor.Services
{
    public class Ffmpeg : IFfmpeg
    {
        readonly ISettingManager _settingManager;
        readonly IPathValidator _pathValidator;

        public Ffmpeg(ISettingManager settingManager, IPathValidator pathValidator)
        {
            _settingManager = settingManager;
            _pathValidator = pathValidator;
        }


        public bool CurrentFfmpegPathValid
        {
            get
            {
                return _pathValidator.ValidFfmpegPath(_settingManager.GetSettings().FfmpegFilePath);
            }
        }


        public string ExecuteTrimCompress(string input, string output, DateTime start, DateTime end, int crf, int width, int height, bool audio, bool audioOnly)
        {
            if (!CurrentFfmpegPathValid) 
                throw new Exception("The ffmpeg path is invalid, please restart");

            string outputString = String.Empty;
            string format = audioOnly ? ".mp3" : ".mp4";
            string compressionString = !audioOnly ?
                $"-ss \"{start:HH:mm:ss}\" -to \"{end:HH:mm:ss}\" -i \"{input}\" -vf \"scale={width}:{height},fps=60\" -c:v libx264 -preset slow -crf {crf} {(!audio ? "-an" : String.Empty)} \"{output}{format}\" "
                : $"-ss \"{start:HH:mm:ss}\" -to \"{end:HH:mm:ss}\" -i \"{input}\" \"{output}{format}\" ";
            
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo(
                    _settingManager.GetSettings().FfmpegFilePath,
                    compressionString
                )
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            process.Start();

            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                outputString += $"{line}\n";
                Debug.WriteLine( $"ConsoleOUT: {line}");
            }
            try
            {
                process.WaitForExit();

            }
            catch (Exception) { }
            finally
            {
                try { process.Kill(); }
                catch(Exception) { }
            }
            return outputString;
        }
    }
}
