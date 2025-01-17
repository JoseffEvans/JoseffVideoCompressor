using JoseffVideoCompressor.Models;
using System;

namespace JoseffVideoCompressor.Services.Interfaces
{
    public interface IFfmpeg
    {
        void ExecuteTrimCompress(FfmpegRequest request, Action<FfmpegResult> onComplete);
        void TryProbe(string path, Action<ProbeResult> onProbe);

        string FfmpegDirectory { get; set; }

        string FfmpegExecutablePath { get; }
        string FfprobeExecuatblePath { get; }

        bool ValidFfmpegDirectory {get;}
        bool HasFfprobe { get; }
    }
}
