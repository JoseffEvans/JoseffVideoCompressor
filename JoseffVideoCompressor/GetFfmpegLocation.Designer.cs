namespace JoseffVideoCompressor
{
    partial class GetFfmpegLocation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.FfmpegPathTextbox = new System.Windows.Forms.TextBox();
            this.FindFfmpegPath = new System.Windows.Forms.Button();
            this.SaveFfmpegLocation = new System.Windows.Forms.Button();
            this.ErrorFfmpegPath = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the filepath to the ffmpeg executable e.g C\\ffmpeg\\ffmpeg.exe\r\nDownl" +
    "oad it from https://ffmpeg.org/download.html";
            // 
            // FfmpegPathTextbox
            // 
            this.FfmpegPathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FfmpegPathTextbox.Location = new System.Drawing.Point(3, 30);
            this.FfmpegPathTextbox.Name = "FfmpegPathTextbox";
            this.FfmpegPathTextbox.Size = new System.Drawing.Size(571, 20);
            this.FfmpegPathTextbox.TabIndex = 1;
            // 
            // FindFfmpegPath
            // 
            this.FindFfmpegPath.Location = new System.Drawing.Point(577, 29);
            this.FindFfmpegPath.Name = "FindFfmpegPath";
            this.FindFfmpegPath.Size = new System.Drawing.Size(75, 23);
            this.FindFfmpegPath.TabIndex = 2;
            this.FindFfmpegPath.Text = "Find";
            this.FindFfmpegPath.UseVisualStyleBackColor = true;
            this.FindFfmpegPath.Click += new System.EventHandler(this.FindFfmpegPath_Click);
            // 
            // SaveFfmpegLocation
            // 
            this.SaveFfmpegLocation.Location = new System.Drawing.Point(3, 56);
            this.SaveFfmpegLocation.Name = "SaveFfmpegLocation";
            this.SaveFfmpegLocation.Size = new System.Drawing.Size(75, 23);
            this.SaveFfmpegLocation.TabIndex = 3;
            this.SaveFfmpegLocation.Text = "Save";
            this.SaveFfmpegLocation.UseVisualStyleBackColor = true;
            this.SaveFfmpegLocation.Click += new System.EventHandler(this.SaveFfmpegLocation_Click);
            // 
            // ErrorFfmpegPath
            // 
            this.ErrorFfmpegPath.AutoSize = true;
            this.ErrorFfmpegPath.ForeColor = System.Drawing.Color.Red;
            this.ErrorFfmpegPath.Location = new System.Drawing.Point(84, 61);
            this.ErrorFfmpegPath.Name = "ErrorFfmpegPath";
            this.ErrorFfmpegPath.Size = new System.Drawing.Size(144, 13);
            this.ErrorFfmpegPath.TabIndex = 4;
            this.ErrorFfmpegPath.Text = "Error: Invalid Ffmpeg Filepath";
            this.ErrorFfmpegPath.Visible = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "ffmpeg (ffmpeg.exe)|ffmpeg.exe";
            // 
            // GetFfmpegLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 265);
            this.Controls.Add(this.ErrorFfmpegPath);
            this.Controls.Add(this.SaveFfmpegLocation);
            this.Controls.Add(this.FindFfmpegPath);
            this.Controls.Add(this.FfmpegPathTextbox);
            this.Controls.Add(this.label1);
            this.Name = "GetFfmpegLocation";
            this.Text = "GetFfmpegLocation";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox FfmpegPathTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindFfmpegPath;
        private System.Windows.Forms.Button SaveFfmpegLocation;
        private System.Windows.Forms.Label ErrorFfmpegPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}