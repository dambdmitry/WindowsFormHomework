namespace MainWinForm
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._pnlSettings = new System.Windows.Forms.Panel();
			this._pnlLog = new System.Windows.Forms.Panel();
			this._pnlPlayer = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// _pnlSettings
			// 
			this._pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlSettings.Location = new System.Drawing.Point(624, 12);
			this._pnlSettings.Name = "_pnlSettings";
			this._pnlSettings.Size = new System.Drawing.Size(164, 291);
			this._pnlSettings.TabIndex = 0;
			// 
			// _pnlLog
			// 
			this._pnlLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlLog.Location = new System.Drawing.Point(7, 309);
			this._pnlLog.Name = "_pnlLog";
			this._pnlLog.Size = new System.Drawing.Size(781, 100);
			this._pnlLog.TabIndex = 1;
			// 
			// _pnlPlayer
			// 
			this._pnlPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlPlayer.Location = new System.Drawing.Point(7, 12);
			this._pnlPlayer.Name = "_pnlPlayer";
			this._pnlPlayer.Size = new System.Drawing.Size(611, 291);
			this._pnlPlayer.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 421);
			this.Controls.Add(this._pnlPlayer);
			this.Controls.Add(this._pnlLog);
			this.Controls.Add(this._pnlSettings);
			this.Name = "MainForm";
			this.Text = "App";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel _pnlSettings;
		private System.Windows.Forms.Panel _pnlLog;
		private System.Windows.Forms.Panel _pnlPlayer;
	}
}

