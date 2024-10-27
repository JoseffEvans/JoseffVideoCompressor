using JoseffVideoCompressor.Models;
using System;

namespace JoseffVideoCompressor.Services.Interfaces
{
    public interface IFfmpeg
    {
        bool CurrentFfmpegPathValid { get; }
        void ExecuteTrimCompress(FfmpegRequest request, Action<FfmpegResult> onComplete);
    }
}
