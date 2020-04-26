namespace Controls
{
	partial class PlayerControl
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
			this._picBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._picBox)).BeginInit();
			this.SuspendLayout();
			// 
			// _picBox
			// 
			this._picBox.Location = new System.Drawing.Point(0, 0);
			this._picBox.Name = "_picBox";
			this._picBox.Size = new System.Drawing.Size(398, 371);
			this._picBox.TabIndex = 0;
			this._picBox.TabStop = false;
			// 
			// PlayerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._picBox);
			this.Name = "PlayerControl";
			this.Size = new System.Drawing.Size(398, 371);
			((System.ComponentModel.ISupportInitialize)(this._picBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox _picBox;
	}
}
