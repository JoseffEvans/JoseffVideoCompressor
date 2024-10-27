namespace JoseffVideoCompressor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._fileInput = new System.Windows.Forms.TextBox();
            this._fileOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._outputFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._updateOutputDirToInput = new System.Windows.Forms.Button();
            this._exec = new System.Windows.Forms.Button();
            this._loadDefault = new System.Windows.Forms.Button();
            this._updateDefault = new System.Windows.Forms.Button();
            this._defaltDirOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._errorInvalidDirectory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._crf = new System.Windows.Forms.TextBox();
            this._errorCrf = new System.Windows.Forms.Label();
            this._width = new System.Windows.Forms.TextBox();
            this._height = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._audio = new System.Windows.Forms.CheckBox();
            this._setRes1 = new System.Windows.Forms.Button();
            this._setRes2 = new System.Windows.Forms.Button();
            this._setRes3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this._aspectRatioWidth = new System.Windows.Forms.TextBox();
            this._aspectRatioHeight = new System.Windows.Forms.TextBox();
            this._audioOnly = new System.Windows.Forms.CheckBox();
            this.SetEndButton = new System.Windows.Forms.Button();
            this.SetTimeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this._lblExecuting = new System.Windows.Forms.Label();
            this._prev = new System.Windows.Forms.Button();
            this._next = new System.Windows.Forms.Button();
            this._executeError = new System.Windows.Forms.Label();
            this._viewOutput = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this._fps = new System.Windows.Forms.TextBox();
            this._interpolateFramerate = new System.Windows.Forms.CheckBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this._startEndTime = new JoseffVideoCompressor.StartEndDate();
            this._gif = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // _fileInput
            // 
            this._fileInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._fileInput.Location = new System.Drawing.Point(12, 24);
            this._fileInput.Name = "_fileInput";
            this._fileInput.Size = new System.Drawing.Size(842, 20);
            this._fileInput.TabIndex = 0;
            this._fileInput.TextChanged += new System.EventHandler(this.FileInput_TextChanged);
            this._fileInput.Leave += new System.EventHandler(this.FileInput_Leave);
            // 
            // _fileOutput
            // 
            this._fileOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._fileOutput.Location = new System.Drawing.Point(12, 121);
            this._fileOutput.Name = "_fileOutput";
            this._fileOutput.Size = new System.Drawing.Size(1006, 20);
            this._fileOutput.TabIndex = 1;
            this._fileOutput.TextChanged += new System.EventHandler(this.FileOutput_TextChanged);
            this._fileOutput.Leave += new System.EventHandler(this.FileOutput_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Path (E.g: C:/Folder/video.mp4)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Directory (E.g: C:/Folder)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output Filename (E.g: output)";
            // 
            // _outputFileName
            // 
            this._outputFileName.Location = new System.Drawing.Point(7, 339);
            this._outputFileName.Name = "_outputFileName";
            this._outputFileName.Size = new System.Drawing.Size(221, 20);
            this._outputFileName.TabIndex = 4;
            this._outputFileName.Text = "output";
            this._outputFileName.TextChanged += new System.EventHandler(this.OutputFileName_TextChanged);
            this._outputFileName.Leave += new System.EventHandler(this.OutputFileName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = ".mp4";
            // 
            // _updateOutputDirToInput
            // 
            this._updateOutputDirToInput.Location = new System.Drawing.Point(15, 92);
            this._updateOutputDirToInput.Name = "_updateOutputDirToInput";
            this._updateOutputDirToInput.Size = new System.Drawing.Size(145, 23);
            this._updateOutputDirToInput.TabIndex = 7;
            this._updateOutputDirToInput.Text = "Update to Input Dir";
            this._updateOutputDirToInput.UseVisualStyleBackColor = true;
            this._updateOutputDirToInput.Click += new System.EventHandler(this.UpdateOutputDirToInput_Click);
            // 
            // _exec
            // 
            this._exec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._exec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this._exec.Location = new System.Drawing.Point(7, 486);
            this._exec.Name = "_exec";
            this._exec.Size = new System.Drawing.Size(131, 45);
            this._exec.TabIndex = 8;
            this._exec.Text = "Execute";
            this._exec.UseVisualStyleBackColor = true;
            this._exec.Click += new System.EventHandler(this.Exec_Click);
            // 
            // _loadDefault
            // 
            this._loadDefault.Location = new System.Drawing.Point(262, 92);
            this._loadDefault.Name = "_loadDefault";
            this._loadDefault.Size = new System.Drawing.Size(145, 23);
            this._loadDefault.TabIndex = 9;
            this._loadDefault.Text = "Load Default";
            this._loadDefault.UseVisualStyleBackColor = true;
            this._loadDefault.Click += new System.EventHandler(this.LoadDefault_Click);
            // 
            // _updateDefault
            // 
            this._updateDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._updateDefault.Location = new System.Drawing.Point(873, 92);
            this._updateDefault.Name = "_updateDefault";
            this._updateDefault.Size = new System.Drawing.Size(145, 23);
            this._updateDefault.TabIndex = 10;
            this._updateDefault.Text = "Update Default";
            this._updateDefault.UseVisualStyleBackColor = true;
            this._updateDefault.Click += new System.EventHandler(this.UpdateDefault_Click);
            // 
            // _defaltDirOutput
            // 
            this._defaltDirOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._defaltDirOutput.Location = new System.Drawing.Point(413, 92);
            this._defaltDirOutput.Name = "_defaltDirOutput";
            this._defaltDirOutput.ReadOnly = true;
            this._defaltDirOutput.Size = new System.Drawing.Size(454, 20);
            this._defaltDirOutput.TabIndex = 11;
            this._defaltDirOutput.TextChanged += new System.EventHandler(this.DefaltDirOutput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Saved Output Directory";
            // 
            // _errorInvalidDirectory
            // 
            this._errorInvalidDirectory.AutoSize = true;
            this._errorInvalidDirectory.ForeColor = System.Drawing.Color.Red;
            this._errorInvalidDirectory.Location = new System.Drawing.Point(12, 144);
            this._errorInvalidDirectory.Name = "_errorInvalidDirectory";
            this._errorInvalidDirectory.Size = new System.Drawing.Size(111, 13);
            this._errorInvalidDirectory.TabIndex = 13;
            this._errorInvalidDirectory.Text = "Error: Invalid Directory";
            this._errorInvalidDirectory.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "CRF (20 - 30)";
            // 
            // _crf
            // 
            this._crf.Location = new System.Drawing.Point(88, 163);
            this._crf.Name = "_crf";
            this._crf.Size = new System.Drawing.Size(89, 20);
            this._crf.TabIndex = 15;
            this._crf.Text = "22";
            this._crf.Validating += new System.ComponentModel.CancelEventHandler(this.Crf_Validating);
            // 
            // _errorCrf
            // 
            this._errorCrf.AutoSize = true;
            this._errorCrf.ForeColor = System.Drawing.Color.Red;
            this._errorCrf.Location = new System.Drawing.Point(177, 166);
            this._errorCrf.Name = "_errorCrf";
            this._errorCrf.Size = new System.Drawing.Size(118, 13);
            this._errorCrf.TabIndex = 16;
            this._errorCrf.Text = "Error: Number Required";
            this._errorCrf.Visible = false;
            // 
            // _width
            // 
            this._width.Location = new System.Drawing.Point(324, 267);
            this._width.Name = "_width";
            this._width.Size = new System.Drawing.Size(89, 20);
            this._width.TabIndex = 18;
            this._width.Text = "960";
            this._width.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // _height
            // 
            this._height.Location = new System.Drawing.Point(413, 267);
            this._height.Name = "_height";
            this._height.Size = new System.Drawing.Size(89, 20);
            this._height.TabIndex = 19;
            this._height.Text = "540";
            this._height.Validating += new System.ComponentModel.CancelEventHandler(this.Height_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Resolution";
            // 
            // _audio
            // 
            this._audio.AutoSize = true;
            this._audio.Checked = true;
            this._audio.CheckState = System.Windows.Forms.CheckState.Checked;
            this._audio.Location = new System.Drawing.Point(324, 204);
            this._audio.Name = "_audio";
            this._audio.Size = new System.Drawing.Size(53, 17);
            this._audio.TabIndex = 22;
            this._audio.Text = "Audio";
            this._audio.UseVisualStyleBackColor = true;
            // 
            // _setRes1
            // 
            this._setRes1.Location = new System.Drawing.Point(324, 293);
            this._setRes1.Name = "_setRes1";
            this._setRes1.Size = new System.Drawing.Size(145, 23);
            this._setRes1.TabIndex = 23;
            this._setRes1.Text = "res1";
            this._setRes1.UseVisualStyleBackColor = true;
            this._setRes1.Click += new System.EventHandler(this.ResButton_Click);
            // 
            // _setRes2
            // 
            this._setRes2.Location = new System.Drawing.Point(324, 317);
            this._setRes2.Name = "_setRes2";
            this._setRes2.Size = new System.Drawing.Size(145, 23);
            this._setRes2.TabIndex = 24;
            this._setRes2.Text = "res 2";
            this._setRes2.UseVisualStyleBackColor = true;
            this._setRes2.Click += new System.EventHandler(this.ResButton_Click);
            // 
            // _setRes3
            // 
            this._setRes3.Location = new System.Drawing.Point(324, 342);
            this._setRes3.Name = "_setRes3";
            this._setRes3.Size = new System.Drawing.Size(145, 23);
            this._setRes3.TabIndex = 25;
            this._setRes3.Text = "res 3";
            this._setRes3.UseVisualStyleBackColor = true;
            this._setRes3.Click += new System.EventHandler(this.ResButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Aspect Ratio";
            // 
            // _aspectRatioWidth
            // 
            this._aspectRatioWidth.Location = new System.Drawing.Point(324, 395);
            this._aspectRatioWidth.Name = "_aspectRatioWidth";
            this._aspectRatioWidth.Size = new System.Drawing.Size(89, 20);
            this._aspectRatioWidth.TabIndex = 27;
            this._aspectRatioWidth.Text = "16";
            this._aspectRatioWidth.Leave += new System.EventHandler(this.AspectRatioWidth_Leave);
            this._aspectRatioWidth.Validating += new System.ComponentModel.CancelEventHandler(this.AspectRatioWidth_Validating);
            // 
            // _aspectRatioHeight
            // 
            this._aspectRatioHeight.Location = new System.Drawing.Point(413, 395);
            this._aspectRatioHeight.Name = "_aspectRatioHeight";
            this._aspectRatioHeight.Size = new System.Drawing.Size(89, 20);
            this._aspectRatioHeight.TabIndex = 28;
            this._aspectRatioHeight.Text = "9";
            this._aspectRatioHeight.Leave += new System.EventHandler(this.AspectRatioHeight_Leave);
            this._aspectRatioHeight.Validating += new System.ComponentModel.CancelEventHandler(this.AspectRatioHeight_Validating);
            // 
            // _audioOnly
            // 
            this._audioOnly.AutoSize = true;
            this._audioOnly.Location = new System.Drawing.Point(324, 181);
            this._audioOnly.Name = "_audioOnly";
            this._audioOnly.Size = new System.Drawing.Size(106, 17);
            this._audioOnly.TabIndex = 29;
            this._audioOnly.Text = "Audio Only (mp3)";
            this._audioOnly.UseVisualStyleBackColor = true;
            // 
            // SetEndButton
            // 
            this.SetEndButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetEndButton.Location = new System.Drawing.Point(931, 486);
            this.SetEndButton.Name = "SetEndButton";
            this.SetEndButton.Size = new System.Drawing.Size(75, 23);
            this.SetEndButton.TabIndex = 31;
            this.SetEndButton.Text = "End";
            this.SetEndButton.UseVisualStyleBackColor = true;
            this.SetEndButton.Click += new System.EventHandler(this.SetEndButton_Click);
            // 
            // SetTimeButton
            // 
            this.SetTimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetTimeButton.Location = new System.Drawing.Point(850, 486);
            this.SetTimeButton.Name = "SetTimeButton";
            this.SetTimeButton.Size = new System.Drawing.Size(75, 23);
            this.SetTimeButton.TabIndex = 30;
            this.SetTimeButton.Text = "Start";
            this.SetTimeButton.UseVisualStyleBackColor = true;
            this.SetTimeButton.Click += new System.EventHandler(this.SetTimeButton_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(792, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Set Time:";
            // 
            // _lblExecuting
            // 
            this._lblExecuting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblExecuting.AutoSize = true;
            this._lblExecuting.ForeColor = System.Drawing.Color.DarkGreen;
            this._lblExecuting.Location = new System.Drawing.Point(144, 488);
            this._lblExecuting.Name = "_lblExecuting";
            this._lblExecuting.Size = new System.Drawing.Size(117, 13);
            this._lblExecuting.TabIndex = 34;
            this._lblExecuting.Text = "Executing, Please Wait";
            this._lblExecuting.Visible = false;
            // 
            // _prev
            // 
            this._prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._prev.Location = new System.Drawing.Point(860, 23);
            this._prev.Name = "_prev";
            this._prev.Size = new System.Drawing.Size(75, 23);
            this._prev.TabIndex = 35;
            this._prev.Text = "Prev";
            this._prev.UseVisualStyleBackColor = true;
            this._prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // _next
            // 
            this._next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._next.Location = new System.Drawing.Point(942, 23);
            this._next.Name = "_next";
            this._next.Size = new System.Drawing.Size(75, 23);
            this._next.TabIndex = 36;
            this._next.Text = "Next";
            this._next.UseVisualStyleBackColor = true;
            this._next.Click += new System.EventHandler(this.Next_Click);
            // 
            // _executeError
            // 
            this._executeError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._executeError.AutoSize = true;
            this._executeError.ForeColor = System.Drawing.Color.Red;
            this._executeError.Location = new System.Drawing.Point(144, 489);
            this._executeError.Name = "_executeError";
            this._executeError.Size = new System.Drawing.Size(101, 13);
            this._executeError.TabIndex = 39;
            this._executeError.Text = "Error, Check Output";
            this._executeError.Visible = false;
            // 
            // _viewOutput
            // 
            this._viewOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._viewOutput.Location = new System.Drawing.Point(144, 508);
            this._viewOutput.Name = "_viewOutput";
            this._viewOutput.Size = new System.Drawing.Size(117, 23);
            this._viewOutput.TabIndex = 40;
            this._viewOutput.Text = "View Output";
            this._viewOutput.UseVisualStyleBackColor = true;
            this._viewOutput.Click += new System.EventHandler(this.ViewOutput_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Fps:";
            // 
            // _fps
            // 
            this._fps.Location = new System.Drawing.Point(353, 423);
            this._fps.Name = "_fps";
            this._fps.Size = new System.Drawing.Size(40, 20);
            this._fps.TabIndex = 42;
            this._fps.Text = "60";
            // 
            // _interpolateFramerate
            // 
            this._interpolateFramerate.AutoSize = true;
            this._interpolateFramerate.Location = new System.Drawing.Point(399, 425);
            this._interpolateFramerate.Name = "_interpolateFramerate";
            this._interpolateFramerate.Size = new System.Drawing.Size(126, 17);
            this._interpolateFramerate.TabIndex = 43;
            this._interpolateFramerate.Text = "Interpolate Framerate";
            this._interpolateFramerate.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(534, 182);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(484, 298);
            this.axWindowsMediaPlayer1.TabIndex = 32;
            // 
            // _startEndTime
            // 
            this._startEndTime.Location = new System.Drawing.Point(7, 189);
            this._startEndTime.Name = "_startEndTime";
            this._startEndTime.Size = new System.Drawing.Size(358, 115);
            this._startEndTime.TabIndex = 17;
            // 
            // _gif
            // 
            this._gif.AutoSize = true;
            this._gif.Location = new System.Drawing.Point(324, 158);
            this._gif.Name = "_gif";
            this._gif.Size = new System.Drawing.Size(39, 17);
            this._gif.TabIndex = 44;
            this._gif.Text = "Gif";
            this._gif.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 549);
            this.Controls.Add(this._gif);
            this.Controls.Add(this._interpolateFramerate);
            this.Controls.Add(this._fps);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._viewOutput);
            this.Controls.Add(this._executeError);
            this.Controls.Add(this._next);
            this.Controls.Add(this._prev);
            this.Controls.Add(this._lblExecuting);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.SetEndButton);
            this.Controls.Add(this.SetTimeButton);
            this.Controls.Add(this._audioOnly);
            this.Controls.Add(this._aspectRatioHeight);
            this.Controls.Add(this._aspectRatioWidth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._setRes3);
            this.Controls.Add(this._setRes2);
            this.Controls.Add(this._setRes1);
            this.Controls.Add(this._audio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._height);
            this.Controls.Add(this._width);
            this.Controls.Add(this._startEndTime);
            this.Controls.Add(this._errorCrf);
            this.Controls.Add(this._crf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._errorInvalidDirectory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._defaltDirOutput);
            this.Controls.Add(this._updateDefault);
            this.Controls.Add(this._loadDefault);
            this.Controls.Add(this._exec);
            this.Controls.Add(this._updateOutputDirToInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._outputFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._fileOutput);
            this.Controls.Add(this._fileInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _fileInput;
        private System.Windows.Forms.TextBox _fileOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _outputFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _updateOutputDirToInput;
        private System.Windows.Forms.Button _exec;
        private System.Windows.Forms.Button _loadDefault;
        private System.Windows.Forms.Button _updateDefault;
        private System.Windows.Forms.TextBox _defaltDirOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _errorInvalidDirectory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _crf;
        private System.Windows.Forms.Label _errorCrf;
        private StartEndDate _startEndTime;
        private System.Windows.Forms.TextBox _width;
        private System.Windows.Forms.TextBox _height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox _audio;
        private System.Windows.Forms.Button _setRes1;
        private System.Windows.Forms.Button _setRes2;
        private System.Windows.Forms.Button _setRes3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _aspectRatioWidth;
        private System.Windows.Forms.TextBox _aspectRatioHeight;
        private System.Windows.Forms.CheckBox _audioOnly;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button SetEndButton;
        private System.Windows.Forms.Button SetTimeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label _lblExecuting;
        private System.Windows.Forms.Button _prev;
        private System.Windows.Forms.Button _next;
        private System.Windows.Forms.Label _executeError;
        private System.Windows.Forms.Button _viewOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _fps;
        private System.Windows.Forms.CheckBox _interpolateFramerate;
        private System.Windows.Forms.CheckBox _gif;
    }
}

