using JoseffVideoCompressor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseffVideoCompressor.Services.Interfaces
{
    public interface ISettingManager
    {
        Settings GetSettings();
        void SetSettings(Settings value);
    }
}
