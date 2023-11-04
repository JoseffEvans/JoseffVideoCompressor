using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseffVideoCompressor.Services.Interfaces
{
    public interface IFolderGetter
    {
        string GetFolderWithFile(string getFolderMsg, string fileName);
    }
}
