using JoseffVideoCompressor.Services.Interfaces;
using System.Diagnostics;
using System.Windows.Forms;

namespace JoseffVideoCompressor.Services
{
    public class FolderGetter : IFolderGetter
    {
        FolderBrowserDialog _filedialog;


        public FolderGetter()
        {
            _filedialog = new FolderBrowserDialog();
        }


        public string GetFolderWithFile(string getFolderMsg, string fileName)
        {
            bool foundFile = false;
            string path = string.Empty;

            while (!foundFile)
            {
                MessageBox.Show(getFolderMsg);
                if(_filedialog.ShowDialog() == DialogResult.OK)
                {
                    path = _filedialog.SelectedPath;
                    Debug.WriteLine(path);
                    foundFile = true;
                }
            }

            return path;
        }
    }
}
