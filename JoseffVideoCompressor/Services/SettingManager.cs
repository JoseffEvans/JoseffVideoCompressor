using JoseffVideoCompressor.Models;
using JoseffVideoCompressor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JoseffVideoCompressor.Services
{
    public class SettingManager : ISettingManager
    {
        const string SETTING_FILENAME = "./settings.json";


        public SettingManager()
        {
            if (!File.Exists(SETTING_FILENAME))
            {
                File.Create(SETTING_FILENAME).Close();
                Settings settings = new Settings()
                {
                    AspectRatioWidth = 16,
                    AspectRatioHeight = 9,
                    FfmpegFileDirectory = @".\ffmpeg\"
                };
                SetSettings(settings);
            }
        }


        public Settings GetSettings()
        {
            return JsonSerializer.Deserialize<Settings>(File.ReadAllText(SETTING_FILENAME));
        }


        ///<summary>Warning: Not an update, overrides all settings</summary>
        public void SetSettings(Settings newSettings)
        {
            File.WriteAllText(SETTING_FILENAME, JsonSerializer.Serialize<Settings>(newSettings));
        }
    }
}
