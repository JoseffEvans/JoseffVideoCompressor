using System;
using System.IO;
using System.Windows.Forms;
using JoseffVideoCompressor.Models;
using JoseffVideoCompressor.Services.Interfaces;


namespace JoseffVideoCompressor
{
    public partial class GetFfmpegLocation : Form
    {
        readonly ISettingManager _settingManager;
        readonly IPathValidator _pathValidator;



        public GetFfmpegLocation(ISettingManager settingManager, IPathValidator pathValidator)
        {
            InitializeComponent();
            _settingManager = settingManager;
            _pathValidator = pathValidator;
        }


        private void FindFfmpegPath_Click(object sender, EventArgs e)
        {
            if(openFileDialog2.ShowDialog() == DialogResult.OK)
                FfmpegPathTextbox.Text = openFileDialog2.FileName;
        }


        private void SaveFfmpegLocation_Click(object sender, EventArgs e)
        {
            if (_pathValidator.ValidFfmpegPath(FfmpegPathTextbox.Text))
            {
                SaveFfmpegPath(FfmpegPathTextbox.Text);
                Close();
            }
            else
                ErrorFfmpegPath.Visible = true;
        }


        private void SaveFfmpegPath(string path)
        {
            Settings settings = _settingManager.GetSettings();
            settings.FfmpegFilePath = path;
            _settingManager.SetSettings(settings);
        }
    }
}
