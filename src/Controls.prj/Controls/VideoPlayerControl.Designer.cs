namespace MainWinForm.Controls
{
	partial class VideoPlayerControl
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
			if(disposing && (components != null))
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
			this._pnlButtonControl = new System.Windows.Forms.Panel();
			this._btnPause = new System.Windows.Forms.Button();
			this._btnStop = new System.Windows.Forms.Button();
			this._btnStart = new System.Windows.Forms.Button();
			this._btnPrev = new System.Windows.Forms.Button();
			this._btnNext = new System.Windows.Forms.Button();
			this._btnOpenDirectory = new System.Windows.Forms.Button();
			this._btnOpenFile = new System.Windows.Forms.Button();
			this._opnFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._opnFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._pnlImage = new System.Windows.Forms.Panel();
			this._picVideo = new OpenCvSharp.UserInterface.PictureBoxIpl();
			this._pnlButtonControl.SuspendLayout();
			this._pnlImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._picVideo)).BeginInit();
			this.SuspendLayout();
			// 
			// _pnlButtonControl
			// 
			this._pnlButtonControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlButtonControl.Controls.Add(this._btnPause);
			this._pnlButtonControl.Controls.Add(this._btnStop);
			this._pnlButtonControl.Controls.Add(this._btnStart);
			this._pnlButtonControl.Controls.Add(this._btnPrev);
			this._pnlButtonControl.Controls.Add(this._btnNext);
			this._pnlButtonControl.Controls.Add(this._btnOpenDirectory);
			this._pnlButtonControl.Controls.Add(this._btnOpenFile);
			this._pnlButtonControl.Location = new System.Drawing.Point(0, 283);
			this._pnlButtonControl.Name = "_pnlButtonControl";
			this._pnlButtonControl.Size = new System.Drawing.Size(684, 81);
			this._pnlButtonControl.TabIndex = 1;
			// 
			// _btnPause
			// 
			this._btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnPause.Location = new System.Drawing.Point(584, 30);
			this._btnPause.Name = "_btnPause";
			this._btnPause.Size = new System.Drawing.Size(75, 23);
			this._btnPause.TabIndex = 6;
			this._btnPause.Text = "Пауза";
			this._btnPause.UseVisualStyleBackColor = true;
			this._btnPause.Click += new System.EventHandler(this.OnPauseClick);
			// 
			// _btnStop
			// 
			this._btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnStop.Location = new System.Drawing.Point(503, 30);
			this._btnStop.Name = "_btnStop";
			this._btnStop.Size = new System.Drawing.Size(75, 23);
			this._btnStop.TabIndex = 5;
			this._btnStop.Text = "Стоп";
			this._btnStop.UseVisualStyleBackColor = true;
			this._btnStop.Click += new System.EventHandler(this.OnStopClick);
			// 
			// _btnStart
			// 
			this._btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnStart.Location = new System.Drawing.Point(422, 30);
			this._btnStart.Name = "_btnStart";
			this._btnStart.Size = new System.Drawing.Size(75, 23);
			this._btnStart.TabIndex = 4;
			this._btnStart.Text = "Старт";
			this._btnStart.UseVisualStyleBackColor = true;
			this._btnStart.Click += new System.EventHandler(this.OnStartClick);
			// 
			// _btnPrev
			// 
			this._btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnPrev.Location = new System.Drawing.Point(122, 30);
			this._btnPrev.Name = "_btnPrev";
			this._btnPrev.Size = new System.Drawing.Size(75, 23);
			this._btnPrev.TabIndex = 3;
			this._btnPrev.Text = "<<";
			this._btnPrev.UseVisualStyleBackColor = true;
			this._btnPrev.Click += new System.EventHandler(this.OnPrevClick);
			// 
			// _btnNext
			// 
			this._btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnNext.Location = new System.Drawing.Point(203, 30);
			this._btnNext.Name = "_btnNext";
			this._btnNext.Size = new System.Drawing.Size(75, 23);
			this._btnNext.TabIndex = 2;
			this._btnNext.Text = ">>";
			this._btnNext.UseVisualStyleBackColor = true;
			this._btnNext.Click += new System.EventHandler(this.OnNextClick);
			// 
			// _btnOpenDirectory
			// 
			this._btnOpenDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnOpenDirectory.Location = new System.Drawing.Point(3, 46);
			this._btnOpenDirectory.Name = "_btnOpenDirectory";
			this._btnOpenDirectory.Size = new System.Drawing.Size(113, 23);
			this._btnOpenDirectory.TabIndex = 1;
			this._btnOpenDirectory.Text = "Открыть папку";
			this._btnOpenDirectory.UseVisualStyleBackColor = true;
			this._btnOpenDirectory.Click += new System.EventHandler(this.OnOpenFolderClick);
			// 
			// _btnOpenFile
			// 
			this._btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnOpenFile.Location = new System.Drawing.Point(3, 17);
			this._btnOpenFile.Name = "_btnOpenFile";
			this._btnOpenFile.Size = new System.Drawing.Size(113, 23);
			this._btnOpenFile.TabIndex = 0;
			this._btnOpenFile.Text = "Открыть файл";
			this._btnOpenFile.UseVisualStyleBackColor = true;
			this._btnOpenFile.Click += new System.EventHandler(this.OnOpenFileClick);
			// 
			// _opnFileDialog
			// 
			this._opnFileDialog.FileName = "openFileDialog1";
			// 
			// _pnlImage
			// 
			this._pnlImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlImage.Controls.Add(this._picVideo);
			this._pnlImage.Location = new System.Drawing.Point(0, 0);
			this._pnlImage.Name = "_pnlImage";
			this._pnlImage.Size = new System.Drawing.Size(684, 277);
			this._pnlImage.TabIndex = 0;
			// 
			// _picVideo
			// 
			this._picVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._picVideo.Location = new System.Drawing.Point(0, 3);
			this._picVideo.Name = "_picVideo";
			this._picVideo.Size = new System.Drawing.Size(681, 271);
			this._picVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this._picVideo.TabIndex = 0;
			this._picVideo.TabStop = false;
			// 
			// VideoPlayerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Controls.Add(this._pnlButtonControl);
			this.Controls.Add(this._pnlImage);
			this.Name = "VideoPlayerControl";
			this.Size = new System.Drawing.Size(684, 364);
			this._pnlButtonControl.ResumeLayout(false);
			this._pnlImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._picVideo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel _pnlButtonControl;
		private System.Windows.Forms.Button _btnPause;
		private System.Windows.Forms.Button _btnStop;
		private System.Windows.Forms.Button _btnStart;
		private System.Windows.Forms.Button _btnPrev;
		private System.Windows.Forms.Button _btnNext;
		private System.Windows.Forms.Button _btnOpenDirectory;
		private System.Windows.Forms.Button _btnOpenFile;
		private System.Windows.Forms.OpenFileDialog _opnFileDialog;
		private System.Windows.Forms.FolderBrowserDialog _opnFolderDialog;
		private System.Windows.Forms.Panel _pnlImage;
		private OpenCvSharp.UserInterface.PictureBoxIpl _picVideo;
	}
}
