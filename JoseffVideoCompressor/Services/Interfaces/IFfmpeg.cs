using System;

namespace JoseffVideoCompressor.Services.Interfaces
{
    public interface IFfmpeg
    {
        bool CurrentFfmpegPathValid { get; }
        string ExecuteTrimCompress(string input, string output, DateTime start, DateTime end, int crf, int width, int height, bool audio, bool audioOnly);
    }
}
