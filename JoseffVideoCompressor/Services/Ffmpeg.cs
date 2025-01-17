using JoseffVideoCompressor.Models;
using JoseffVideoCompressor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;

namespace JoseffVideoCompressor.Services {
    public class Ffmpeg : IFfmpeg {
        readonly ISettingManager _settingManager;

        string _ffmpegDirectory;

        public Ffmpeg(ISettingManager settingManager) {
            _settingManager = settingManager;
            FfmpegDirectory = settingManager.GetSettings().FfmpegFileDirectory;
        }

        public string FfmpegDirectory {
            get => _ffmpegDirectory;
            set {
                _ffmpegDirectory = value;

                if(string.IsNullOrWhiteSpace(value) || !Directory.Exists(value)) {
                    ValidFfmpegDirectory = false;
                    HasFfprobe = false;
                    return;
                }

                FfmpegExecutablePath = Path.Combine(value, "ffmpeg.exe");
                ValidFfmpegDirectory = File.Exists(FfmpegExecutablePath);

                FfprobeExecuatblePath = Path.Combine(value, "ffprobe.exe");
                HasFfprobe = File.Exists(FfprobeExecuatblePath);

                if(ValidFfmpegDirectory) {
                    var settings = _settingManager.GetSettings();
                    settings.FfmpegFileDirectory = value;
                    _settingManager.SetSettings(settings);
                }
            }
        }

        public bool ValidFfmpegDirectory { get; protected set; }
        public bool HasFfprobe { get; protected set; }

        public string FfmpegExecutablePath { get; protected set; }
        public string FfprobeExecuatblePath { get; protected set; }


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
            if(!ValidFfmpegDirectory)
                throw new Exception("The ffmpeg path is invalid, please set it");

            var thread = new Thread(() => {
                string compressionString = request.AudioOnly
                    ? GetAudio(request)
                    : request.Gif
                    ? GetGif(request)
                    : GetCompressed(request);

                Process process = new Process {
                    StartInfo = new ProcessStartInfo(
                        FfmpegExecutablePath,
                        compressionString
                    ) {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                string outputString = $"----Input----\nCommmand: \n ${compressionString} \n\n----Output----\n";

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

        class ProbeOutput {
            [JsonPropertyName("streams")]
            public List<ProbeResult> Streams { get; set; }
        }

        public void TryProbe(string filepath, Action<ProbeResult> onProbed) {
            if(!ValidFfmpegDirectory || !HasFfprobe) 
                return;

            var thread = new Thread(() => {
                var arguments = 
                    $"-i \"{filepath}\" " +
                    $"-show_entries stream=height,width,duration,display_aspect_ratio " +
                    $"-v quiet -of json=c=1 -select_streams v:0";

                var process = new Process {
                    StartInfo = new ProcessStartInfo(
                        FfprobeExecuatblePath,
                        arguments
                    ) {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = false,
                        CreateNoWindow = true
                    }
                };

                var outputString = string.Empty;
                process.OutputDataReceived += (sender, args) => outputString += args.Data;

                process.Start();
                process.BeginOutputReadLine();

                try {
                    process.WaitForExit();
                } catch(Exception ex) {
                    Debug.WriteLine(ex.Message);
                } finally {
                    try { 
                        process.Kill(); 
                    } catch(Exception) { }
                }
                try {
                    var output = JsonSerializer.Deserialize<ProbeOutput>(outputString);
                    if(output is null || output.Streams.Count != 1)
                        return;

                    var result = output.Streams[0];

                    if(result != null && result.Valid)
                        onProbed(result);
                } catch(Exception) { }
            });
            thread.Start();
        }
    }
}
