using JoseffVideoCompressor.Models;
using JoseffVideoCompressor.Services.Interfaces;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace JoseffVideoCompressor.Services {
    public class Ffmpeg : IFfmpeg {
        readonly ISettingManager _settingManager;
        readonly IPathValidator _pathValidator;

        public Ffmpeg(ISettingManager settingManager, IPathValidator pathValidator) {
            _settingManager = settingManager;
            _pathValidator = pathValidator;
        }

        public bool CurrentFfmpegPathValid {
            get => _pathValidator.ValidFfmpegPath(_settingManager.GetSettings().FfmpegFilePath);
        }

        string GetAudio(FfmpegRequest request) =>
            $"-ss \"{request.Start:HH:mm:ss}\" -to \"{request.End:HH:mm:ss}\"" +
            $" -i \"{request.Input}\" \"{request.Output}.mp3\" ";

        string GetGif(FfmpegRequest request) => $"-ss \"{request.Start:HH:mm:ss}\" -to \"{request.End:HH:mm:ss}\" " +
            $"-i \"{request.Input}\" " +
            $"-vf \"fps={request.Fps}," +
            $"scale={request.Width}:{request.Height}\" " +
            $"\"{request.Output}.gif\" ";

        string GetCompressed(FfmpegRequest request) =>
            $"-ss \"{request.Start:HH:mm:ss}\" -to \"{request.End:HH:mm:ss}\" " +
            $"-i \"{request.Input}\" " +
            $"-vf \"scale={request.Width}:{request.Height}," +
            $"{GetFps(request)}\" " +
            $"-c:v libx264 -preset slow -crf {request.Crf} " +
            $"{(!request.Audio ? "-an" : string.Empty)} " +
            $"\"{request.Output}.mp4\" ";

        string GetFps(FfmpegRequest request) =>
            request.InterpolatedFramerate
                ? $"minterpolate=fps={request.Fps}:mi_mode=mci:mc_mode=aobmc:me_mode=bidir:vsbmc=1"
                : $"fps={request.Fps}";

        public void ExecuteTrimCompress(FfmpegRequest request, Action<FfmpegResult> onComplete) {
            if(!CurrentFfmpegPathValid)
                throw new Exception("The ffmpeg path is invalid, please restart");

            var thread = new Thread(() => {
                string compressionString = request.AudioOnly
                    ? GetAudio(request)
                    : request.Gif
                    ? GetGif(request)
                    : GetCompressed(request);

                Process process = new Process {
                    StartInfo = new ProcessStartInfo(
                        _settingManager.GetSettings().FfmpegFilePath,
                        compressionString
                    ) {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                string outputString = $"----Input----\nCommmand: \n ${compressionString} \n----Output----";

                process.OutputDataReceived += (sender, args) => outputString += $"{args.Data}\n";
                process.ErrorDataReceived += (sender, args) => {
                    outputString += $"{args.Data}\n";
                };

                process.Start();

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                try {
                    process.WaitForExit();
                } catch(Exception) { } finally {
                    try { process.Kill(); } catch(Exception) { }
                }

                onComplete(new FfmpegResult() {
                    Error = process.ExitCode != 0,
                    Output = outputString
                });
            });
            thread.Start();
        }
    }
}
