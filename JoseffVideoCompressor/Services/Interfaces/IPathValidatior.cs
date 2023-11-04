using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseffVideoCompressor.Services.Interfaces
{
    public interface IPathValidator
    {
        bool ValidPath(string path);
        bool ValidFfmpegPath(string ffmpegPath);
    }
}
