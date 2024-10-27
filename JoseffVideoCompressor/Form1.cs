using JoseffVideoCompressor.Models;
using JoseffVideoCompressor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoseffVideoCompressor {
    public partial class Form1 : Form {
        private readonly ISettingManager _setting;
        private readonly IFfmpeg _ffmpeg;
        private string _lastOutput;

        private const int RES1_MULTIPLIER = 40;
        private const int RES2_MULTIPLIER = 60;
        private const int RES3_MULTIPLIER = 80;

        public Form1(ISettingManager setting, IFfmpeg ffmpeg) {
            InitializeComponent();
            _setting = setting;
            _ffmpeg = ffmpeg;
            GetDefaultOutputDirFromSettings();
            _outputFileName.Text = $"Video Ouput {DateTime.Now:yyyy-MM-dd HH-mm-ss}";
            SetExecuteEnabled();
        }

        #region "Event Handlers"
        // -- Form -- //

        private void Form1_Load(object sender, EventArgs e) {
            Settings settings = _setting.GetSettings();
            _updateOutputDirToInput.Enabled = InputDirIsValid();
            _aspectRatioHeight.Text = settings.AspectRatioHeight.ToString();
            _aspectRatioWidth.Text = settings.AspectRatioWidth.ToString();
            _width.Text = (int.Parse(_aspectRatioWidth.Text) * RES2_MULTIPLIER).ToString();
            _height.Text = (int.Parse(_aspectRatioHeight.Text) * RES2_MULTIPLIER).ToString();
            SetResButtons();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            if(filePaths.Length != 0)
                _fileInput.Text = filePaths[0];
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        // -- Text Changed -- // 

        private void FileInput_TextChanged(object sender, EventArgs e) {
            _fileInput.Text = RemoveQuotes(_fileInput.Text);
            SetContent(_fileInput.Text);
            SetExecuteEnabled();
        }

        private void FileOutput_TextChanged(object sender, EventArgs e) {
            SetExecuteEnabled();
        }

        private void DefaltDirOutput_TextChanged(object sender, EventArgs e) {
            SetLoadDefaultEnabled();
        }

        private void OutputFileName_TextChanged(object sender, EventArgs e) {
            SetExecuteEnabled();
        }

        // -- Leave -- //

        private void FileOutput_Leave(object sender, EventArgs e) {
            if(_fileOutput.Text.EndsWith("/")) _fileOutput.Text = _fileOutput.Text.TrimEnd('/');
            _errorInvalidDirectory.Visible = OutputDirIsValid();
        }

        private void OutputFileName_Leave(object sender, EventArgs e) {
            if(_outputFileName.Text.EndsWith(".mp4")) _outputFileName.Text =
                    _outputFileName.Text.Remove(_outputFileName.Text.Length - ".mp4".Length, ".mp4".Length);
        }

        private void FileInput_Leave(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(_fileOutput.Text))
                UpdateOutputDirToInput();
            _updateOutputDirToInput.Enabled = InputDirIsValid();
        }

        private void AspectRatioWidth_Leave(object sender, EventArgs e) {
            SetResButtons();
            Settings settings = _setting.GetSettings();
            settings.AspectRatioWidth = int.Parse(_aspectRatioWidth.Text);
            _setting.SetSettings(settings);
        }

        private void AspectRatioHeight_Leave(object sender, EventArgs e) {
            SetResButtons();
            Settings settings = _setting.GetSettings();
            settings.AspectRatioHeight = int.Parse(_aspectRatioHeight.Text);
            _setting.SetSettings(settings);
        }

        // -- Click -- //

        private void Exec_Click(object sender, EventArgs e) {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            _lblExecuting.Visible = true;
            _executeError.Visible = false;
            _exec.Enabled = false;
            Update();
            _ffmpeg.ExecuteTrimCompress(new FfmpegRequest {
                Input = _fileInput.Text,
                Output = GetOutputName(),
                Start = _startEndTime.GetStartTime() ?? DateTime.Now,
                End = _startEndTime.GetEndTime() ?? DateTime.Now,
                Crf = int.Parse(_crf.Text),
                Width = int.Parse(_width.Text),
                Height = int.Parse(_height.Text),
                Audio = _audio.Checked,
                AudioOnly = _audioOnly.Checked,
                Fps = int.Parse(_fps.Text),
                InterpolatedFramerate = _interpolateFramerate.Checked,
                Gif = _gif.Checked
            },
            (FfmpegResult result) => {
                Invoke((MethodInvoker)delegate {
                    _outputFileName.Text = $"Video Ouput {DateTime.Now:yyyy-MM-dd HH-mm-ss}";

                    _exec.Enabled = true;
                    _lblExecuting.Visible = false;
                    _executeError.Visible = result.Error;
                    _lastOutput = result.Output;
                });
            });
        }

        private void UpdateOutputDirToInput_Click(object sender, EventArgs e) {
            UpdateOutputDirToInput();
        }
        private void LoadDefault_Click(object sender, EventArgs e) {
            _fileOutput.Text = _defaltDirOutput.Text;
            _errorInvalidDirectory.Visible = OutputDirIsValid();
        }

        private void UpdateDefault_Click(object sender, EventArgs e) {
            Settings settings = _setting.GetSettings();
            settings.SavedOutputDir = _fileOutput.Text;
            _setting.SetSettings(settings);
            GetDefaultOutputDirFromSettings();
        }

        private void ResButton_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            _width.Text = button.Text.Split(':')[0];
            _height.Text = button.Text.Split(':')[1];
        }

        private void SetTimeButton_Click(object sender, EventArgs e) {
            _startEndTime.SetStartTime(TimeFromPos(axWindowsMediaPlayer1.Ctlcontrols.currentPositionString));
        }

        private void SetEndButton_Click(object sender, EventArgs e) {
            _startEndTime.SetEndTime(TimeFromPos(axWindowsMediaPlayer1.Ctlcontrols.currentPositionString));
        }

        private void Next_Click(object sender, EventArgs e) {
            ScrollFile(true);
        }

        private void Prev_Click(object sender, EventArgs e) {
            ScrollFile(false);
        }

        // -- Validating -- //

        private void Crf_Validating(object sender, CancelEventArgs e) {
            int _;
            bool valid = int.TryParse(_crf.Text, out _);
            e.Cancel = !valid;
            _errorCrf.Visible = !valid;
        }

        private void Width_Validating(object sender, CancelEventArgs e) {
            int _;
            bool valid = int.TryParse(_width.Text, out _);
            e.Cancel = !valid;
        }

        private void Height_Validating(object sender, CancelEventArgs e) {
            int _;
            bool valid = int.TryParse(_height.Text, out _);
            e.Cancel = !valid;
        }

        private void AspectRatioWidth_Validating(object sender, CancelEventArgs e) {
            int _;
            bool valid = int.TryParse(_aspectRatioWidth.Text, out _);
            e.Cancel = !valid;
        }

        private void AspectRatioHeight_Validating(object sender, CancelEventArgs e) {
            int _;
            bool valid = int.TryParse(_aspectRatioHeight.Text, out _);
            e.Cancel = !valid;
        }
        #endregion "Event Handlers"

        // -- Private -- //

        private string RemoveQuotes(string str) {
            if(str.StartsWith("\"")) str = str.TrimStart('\"');
            if(str.EndsWith("\"")) str = str.TrimEnd('\"');
            return str;
        }

        private bool InputDirIsValid() {
            try {
                return Directory.Exists(Path.GetDirectoryName(_fileInput.Text));
            } catch(Exception) {
                return false;
            }
        }

        private bool OutputDirIsValid() {
            try {
                return !Directory.Exists(_fileOutput.Text);
            } catch(Exception) {
                return false;
            }
        }

        private void UpdateOutputDirToInput() {
            if(InputDirIsValid())
                _fileOutput.Text = Path.GetDirectoryName(_fileInput.Text);
        }

        private string GetOutputName() {
            return $"{_fileOutput.Text}/{_outputFileName.Text}";
        }

        private void GetDefaultOutputDirFromSettings() {
            Settings settings = _setting.GetSettings();
            _defaltDirOutput.Text = settings.SavedOutputDir;
            SetLoadDefaultEnabled();
        }

        private void SetLoadDefaultEnabled() {
            _loadDefault.Enabled = !string.IsNullOrEmpty(_defaltDirOutput.Text);
        }

        private void SetExecuteEnabled() {
            try {
                _exec.Enabled = Directory.Exists(_fileOutput.Text) &&
                    !string.IsNullOrEmpty(_outputFileName.Text) &&
                    File.Exists(_fileInput.Text);
            } catch(Exception) {
                _exec.Enabled = false;
            }
        }


        public void SetResButtons() {
            int apectRatioWidth = int.Parse(_aspectRatioWidth.Text);
            int apectRatioHeight = int.Parse(_aspectRatioHeight.Text);

            _setRes1.Text = $"{RES1_MULTIPLIER * apectRatioWidth}:{RES1_MULTIPLIER * apectRatioHeight}";
            _setRes2.Text = $"{RES2_MULTIPLIER * apectRatioWidth}:{RES2_MULTIPLIER * apectRatioHeight}";
            _setRes3.Text = $"{RES3_MULTIPLIER * apectRatioWidth}:{RES3_MULTIPLIER * apectRatioHeight}";
        }

        public bool SetContent(string url) {
            bool success = true;

            if(ValidContent(url))
                axWindowsMediaPlayer1.URL = url;
            else
                success = false;

            return success;
        }

        private bool ValidContent(string url) {
            return
                !string.IsNullOrEmpty(url) &&
                Directory.Exists(Path.GetDirectoryName(url)) &&
                File.Exists(url);
        }

        private static DateTime TimeFromPos(string pos) {
            DateTime time = new DateTime();
            var timestamps = pos.Split(':').Reverse();

            int i = 0;
            foreach(string stamp in timestamps) {
                if(i == 0 && stamp == string.Empty) continue;

                if(i == 0) time = time.AddSeconds(int.Parse(stamp));
                if(i == 1) time = time.AddMinutes(int.Parse(stamp));
                if(i == 2) time = time.AddHours(int.Parse(stamp));

                i++;
            }

            return time;
        }

        private void ScrollFile(bool next) {

            if(ValidContent(_fileInput.Text)) {
                string prev = null;
                string[] files = Directory.GetFiles(Path.GetDirectoryName(_fileInput.Text));

                for(int i = next ? files.Length - 1 : 0; next ? i >= 0 : i < files.Length; i = next ? i - 1 : i + 1)
                    if(files[i] == _fileInput.Text && prev != null)
                        _fileInput.Text = prev;
                    else
                        prev = files[i];
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            axWindowsMediaPlayer1.Dispose();
        }

        private void ViewOutput_Click(object sender, EventArgs e) {
            MessageBox.Show(
                _lastOutput
            );
        }
    }
}
