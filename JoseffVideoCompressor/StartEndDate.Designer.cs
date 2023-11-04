namespace JoseffVideoCompressor
{
    partial class StartEndDate
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this._startHours = new System.Windows.Forms.TextBox();
            this._startMins = new System.Windows.Forms.TextBox();
            this._startSecs = new System.Windows.Forms.TextBox();
            this._endSecs = new System.Windows.Forms.TextBox();
            this._endMins = new System.Windows.Forms.TextBox();
            this._endHours = new System.Windows.Forms.TextBox();
            this._errorTimeValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Time";
            // 
            // _startHours
            // 
            this._startHours.Location = new System.Drawing.Point(3, 26);
            this._startHours.Name = "_startHours";
            this._startHours.Size = new System.Drawing.Size(36, 20);
            this._startHours.TabIndex = 1;
            this._startHours.Text = "0";
            this._startHours.Validating += new System.ComponentModel.CancelEventHandler(this.StartHours_Validating);
            // 
            // _startMins
            // 
            this._startMins.Location = new System.Drawing.Point(45, 26);
            this._startMins.Name = "_startMins";
            this._startMins.Size = new System.Drawing.Size(36, 20);
            this._startMins.TabIndex = 2;
            this._startMins.Text = "0";
            this._startMins.Validating += new System.ComponentModel.CancelEventHandler(this.StartMins_Validating);
            // 
            // _startSecs
            // 
            this._startSecs.Location = new System.Drawing.Point(87, 26);
            this._startSecs.Name = "_startSecs";
            this._startSecs.Size = new System.Drawing.Size(36, 20);
            this._startSecs.TabIndex = 3;
            this._startSecs.Text = "0";
            this._startSecs.Validating += new System.ComponentModel.CancelEventHandler(this.StartSecs_Validating);
            // 
            // _endSecs
            // 
            this._endSecs.Location = new System.Drawing.Point(87, 90);
            this._endSecs.Name = "_endSecs";
            this._endSecs.Size = new System.Drawing.Size(36, 20);
            this._endSecs.TabIndex = 6;
            this._endSecs.Text = "0";
            this._endSecs.Validating += new System.ComponentModel.CancelEventHandler(this.EndSecs_Validating);
            // 
            // _endMins
            // 
            this._endMins.Location = new System.Drawing.Point(45, 90);
            this._endMins.Name = "_endMins";
            this._endMins.Size = new System.Drawing.Size(36, 20);
            this._endMins.TabIndex = 5;
            this._endMins.Text = "0";
            this._endMins.Validating += new System.ComponentModel.CancelEventHandler(this.EndMins_Validating);
            // 
            // _endHours
            // 
            this._endHours.Location = new System.Drawing.Point(3, 90);
            this._endHours.Name = "_endHours";
            this._endHours.Size = new System.Drawing.Size(36, 20);
            this._endHours.TabIndex = 4;
            this._endHours.Text = "0";
            this._endHours.Validating += new System.ComponentModel.CancelEventHandler(this.EndHours_Validating);
            // 
            // _errorTimeValue
            // 
            this._errorTimeValue.AutoSize = true;
            this._errorTimeValue.ForeColor = System.Drawing.Color.Red;
            this._errorTimeValue.Location = new System.Drawing.Point(4, 53);
            this._errorTimeValue.Name = "_errorTimeValue";
            this._errorTimeValue.Size = new System.Drawing.Size(96, 13);
            this._errorTimeValue.TabIndex = 7;
            this._errorTimeValue.Text = "Error: Invalid Value";
            this._errorTimeValue.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "End Time";
            // 
            // StartEndDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this._errorTimeValue);
            this.Controls.Add(this._endSecs);
            this.Controls.Add(this._endMins);
            this.Controls.Add(this._endHours);
            this.Controls.Add(this._startSecs);
            this.Controls.Add(this._startMins);
            this.Controls.Add(this._startHours);
            this.Controls.Add(this.label1);
            this.Name = "StartEndDate";
            this.Size = new System.Drawing.Size(358, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _startHours;
        private System.Windows.Forms.TextBox _startMins;
        private System.Windows.Forms.TextBox _startSecs;
        private System.Windows.Forms.TextBox _endSecs;
        private System.Windows.Forms.TextBox _endMins;
        private System.Windows.Forms.TextBox _endHours;
        private System.Windows.Forms.Label _errorTimeValue;
        private System.Windows.Forms.Label label3;
    }
}
