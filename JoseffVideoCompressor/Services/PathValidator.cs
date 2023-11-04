using JoseffVideoCompressor.Services.Interfaces;
using System;
using System.IO;

namespace JoseffVideoCompressor.Services
{
    internal class PathValidator : IPathValidator
    {
        public bool ValidPath(string path)
        {
            return 
                !string.IsNullOrEmpty(path) &&
                File.Exists(path);
        }


        public bool ValidFfmpegPath(string ffmpegPath)
        {
            try
            {
                return
                    ValidPath(ffmpegPath) &&
                    Path.GetFileName(ffmpegPath) == "ffmpeg.exe";
            }
            catch (Exception)
            {
                return false;
            }

        }

    }

}
