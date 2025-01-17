using System;
using System.Text.Json.Serialization;
using System.Windows.Markup;

namespace JoseffVideoCompressor.Models {
    public class ProbeResult {
        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("duration")]
        public string DurationString { get; set; }

        public int DurationSeconds { 
            get {
                if(!double.TryParse(DurationString, out double duration))
                    return default;

                return (int)Math.Floor(duration);
            } 
        }

        public TimeSpan Duration {
            get {
                if(DurationSeconds == default) 
                    return default;

                return TimeSpan.FromSeconds(DurationSeconds);
            }
        }

        public int AspectRatioWidth { get; set; }
        public int AspectRatioHeight { get; set; }

        [JsonPropertyName("display_aspect_ratio")]
        public string AspectRatioString {
            set {
                if(value is null) return;

                var parts = value.Split(':');
                if(parts.Length < 2 || !int.TryParse(parts[0], out int width) || !int.TryParse(parts[1], out int height))
                    return;

                AspectRatioWidth = width;
                AspectRatioHeight = height;
            }
            get => $"{AspectRatioWidth}:{AspectRatioHeight}";
        }

        public bool Valid {
            get =>
                Height != default &&
                Width != default &&
                AspectRatioWidth != default &&
                AspectRatioHeight != default;
        }
    }
}
