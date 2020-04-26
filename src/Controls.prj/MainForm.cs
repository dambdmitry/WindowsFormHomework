using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
	public partial class MainForm : Form
	{
		private ProjectSettings _projectSettings;
		public MainForm(ProjectSettings projectSettings)
		{
			_projectSettings = projectSettings;

			InitializeComponent();

			//Инициализируем наши контролы.
			var playerControl = new PlayerControl();
			_pnlPlayer.Controls.Add(playerControl);
			playerControl.Dock = DockStyle.Fill;

			var settingsControl = new SettingsControl();
			_pnlSettings.Controls.Add(settingsControl);
			settingsControl.Dock = DockStyle.Fill;

			var logControl = new LogControl();
			_pnlLog.Controls.Add(logControl);
			logControl.Dock = DockStyle.Fill;
		}
	}
}
