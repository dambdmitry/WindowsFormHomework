namespace Controls
{
	partial class SettingsControl
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
			this._btnOpenFile = new System.Windows.Forms.Button();
			this._btnOpenFolder = new System.Windows.Forms.Button();
			this._btnStart = new System.Windows.Forms.Button();
			this._btnPause = new System.Windows.Forms.Button();
			this._btnBack = new System.Windows.Forms.Button();
			this._btnForward = new System.Windows.Forms.Button();
			this._btnStop = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _btnOpenFile
			// 
			this._btnOpenFile.Location = new System.Drawing.Point(3, 3);
			this._btnOpenFile.Name = "_btnOpenFile";
			this._btnOpenFile.Size = new System.Drawing.Size(109, 25);
			this._btnOpenFile.TabIndex = 0;
			this._btnOpenFile.Text = "Открыть файл";
			this._btnOpenFile.UseVisualStyleBackColor = true;
			// 
			// _btnOpenFolder
			// 
			this._btnOpenFolder.Location = new System.Drawing.Point(3, 34);
			this._btnOpenFolder.Name = "_btnOpenFolder";
			this._btnOpenFolder.Size = new System.Drawing.Size(109, 25);
			this._btnOpenFolder.TabIndex = 1;
			this._btnOpenFolder.Text = "Открыть папку";
			this._btnOpenFolder.UseVisualStyleBackColor = true;
			// 
			// _btnStart
			// 
			this._btnStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._btnStart.Location = new System.Drawing.Point(12, 88);
			this._btnStart.Name = "_btnStart";
			this._btnStart.Size = new System.Drawing.Size(68, 64);
			this._btnStart.TabIndex = 2;
			this._btnStart.Text = "Старт";
			this._btnStart.UseVisualStyleBackColor = true;
			// 
			// _btnPause
			// 
			this._btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._btnPause.Location = new System.Drawing.Point(99, 88);
			this._btnPause.Name = "_btnPause";
			this._btnPause.Size = new System.Drawing.Size(68, 64);
			this._btnPause.TabIndex = 3;
			this._btnPause.Text = "Пауза";
			this._btnPause.UseVisualStyleBackColor = true;
			// 
			// _btnBack
			// 
			this._btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._btnBack.Location = new System.Drawing.Point(12, 162);
			this._btnBack.Name = "_btnBack";
			this._btnBack.Size = new System.Drawing.Size(75, 67);
			this._btnBack.TabIndex = 4;
			this._btnBack.Text = "<<";
			this._btnBack.UseVisualStyleBackColor = true;
			// 
			// _btnForward
			// 
			this._btnForward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this._btnForward.Location = new System.Drawing.Point(183, 162);
			this._btnForward.Name = "_btnForward";
			this._btnForward.Size = new System.Drawing.Size(75, 67);
			this._btnForward.TabIndex = 5;
			this._btnForward.Text = ">>";
			this._btnForward.UseVisualStyleBackColor = true;
			// 
			// _btnStop
			// 
			this._btnStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._btnStop.Location = new System.Drawing.Point(190, 88);
			this._btnStop.Name = "_btnStop";
			this._btnStop.Size = new System.Drawing.Size(68, 64);
			this._btnStop.TabIndex = 6;
			this._btnStop.Text = "Стоп";
			this._btnStop.UseVisualStyleBackColor = true;
			// 
			// SettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.Controls.Add(this._btnStop);
			this.Controls.Add(this._btnForward);
			this.Controls.Add(this._btnBack);
			this.Controls.Add(this._btnPause);
			this.Controls.Add(this._btnStart);
			this.Controls.Add(this._btnOpenFolder);
			this.Controls.Add(this._btnOpenFile);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(271, 233);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btnOpenFile;
		private System.Windows.Forms.Button _btnOpenFolder;
		private System.Windows.Forms.Button _btnStart;
		private System.Windows.Forms.Button _btnPause;
		private System.Windows.Forms.Button _btnBack;
		private System.Windows.Forms.Button _btnForward;
		private System.Windows.Forms.Button _btnStop;
	}
}
