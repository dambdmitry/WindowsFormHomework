namespace MainWinForm.Controls
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
			this._chkDetector = new System.Windows.Forms.CheckBox();
			this._chkIsUnderCatalog = new System.Windows.Forms.CheckBox();
			this._btnSave = new System.Windows.Forms.Button();
			this._btnLoad = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _chkDetector
			// 
			this._chkDetector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._chkDetector.AutoSize = true;
			this._chkDetector.Location = new System.Drawing.Point(17, 15);
			this._chkDetector.Name = "_chkDetector";
			this._chkDetector.Size = new System.Drawing.Size(114, 17);
			this._chkDetector.TabIndex = 0;
			this._chkDetector.Text = "Детектор сцепок";
			this._chkDetector.UseVisualStyleBackColor = true;
			this._chkDetector.CheckedChanged += new System.EventHandler(this.OnChangeDetector);
			// 
			// _chkIsUnderCatalog
			// 
			this._chkIsUnderCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._chkIsUnderCatalog.AutoSize = true;
			this._chkIsUnderCatalog.Location = new System.Drawing.Point(17, 38);
			this._chkIsUnderCatalog.Name = "_chkIsUnderCatalog";
			this._chkIsUnderCatalog.Size = new System.Drawing.Size(114, 17);
			this._chkIsUnderCatalog.TabIndex = 1;
			this._chkIsUnderCatalog.Text = "С подкатологами";
			this._chkIsUnderCatalog.UseVisualStyleBackColor = true;
			this._chkIsUnderCatalog.CheckedChanged += new System.EventHandler(this.OnChangeUnderCatalog);
			// 
			// _btnSave
			// 
			this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSave.Location = new System.Drawing.Point(38, 74);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 23);
			this._btnSave.TabIndex = 2;
			this._btnSave.Text = "Сохранить";
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.Click += new System.EventHandler(this.OnSaveClick);
			// 
			// _btnLoad
			// 
			this._btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnLoad.Location = new System.Drawing.Point(38, 103);
			this._btnLoad.Name = "_btnLoad";
			this._btnLoad.Size = new System.Drawing.Size(75, 23);
			this._btnLoad.TabIndex = 3;
			this._btnLoad.Text = "Загрузить";
			this._btnLoad.UseVisualStyleBackColor = true;
			// 
			// SettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Controls.Add(this._btnLoad);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._chkIsUnderCatalog);
			this.Controls.Add(this._chkDetector);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(168, 420);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox _chkDetector;
		private System.Windows.Forms.CheckBox _chkIsUnderCatalog;
		private System.Windows.Forms.Button _btnSave;
		private System.Windows.Forms.Button _btnLoad;
	}
}
