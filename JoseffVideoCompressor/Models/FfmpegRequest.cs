using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace JoseffVideoCompressor.Models {
    public class FfmpegRequest {
        public string Input;
        public string Output;
        public DateTime Start;
        public DateTime End;
        public int Crf;
        public int Width;
        public int Height;
        public bool AudioOnly;
        public bool Audio;
        public int Fps;
        public bool InterpolatedFramerate;
        public bool Gif;
    }
}
