using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoseffVideoCompressor
{
    public partial class StartEndDate : UserControl
    {
        public StartEndDate()
        {
            InitializeComponent();
        }

        private DateTime? GetTime(TextBox secBox, TextBox minBox, TextBox hourBox)
        {
            int sec, min, hour;
            bool secOk, minOK, hourOk;
            secOk = int.TryParse(secBox.Text, out sec) && sec < 60 && sec >= 0;
            minOK = int.TryParse(minBox.Text, out min) && min < 60 && min >= 0;
            hourOk = int.TryParse(hourBox.Text, out hour) && hour < 24 && hour >= 0;

            if(!secOk || !minOK || !hourOk)
            {
                _errorTimeValue.Visible = true;
                return null;
            }
            else
            {
                _errorTimeValue.Visible = false;
                return new DateTime(1, 1, 1, hour, min, sec);
            }
        }

        private void SetTime(TextBox secBox, TextBox minBox, TextBox hourBox, DateTime time)
        {
            secBox.Text = time.Second.ToString();
            minBox.Text = time.Minute.ToString();
            hourBox.Text = time.Hour.ToString();
        }

        public DateTime? GetStartTime()
        {
            return GetTime(_startSecs, _startMins, _startHours);
        }

        public DateTime? GetEndTime()
        {
            return GetTime(_endSecs, _endMins, _endHours);
        }

        public void SetStartTime(DateTime time)
        {
            SetTime(_startSecs, _startMins, _startHours, time);
        }

        public void SetEndTime(DateTime time)
        {
            SetTime(_endSecs, _endMins, _endHours, time);
        }

        private void StartSecs_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = GetStartTime() is null || GetEndTime() is null;
        }

        private void StartMins_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = GetStartTime() is null || GetEndTime() is null;
        }

        private void StartHours_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = GetStartTime() is null || GetEndTime() is null;
        }

        private void EndHours_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = GetStartTime() is null || GetEndTime() is null;
        }

        private void EndMins_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = GetStartTime() is null || GetEndTime() is null;
        }

        private void EndSecs_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = GetStartTime() is null || GetEndTime() is null;
        }
    }
}
