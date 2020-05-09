using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainWinForm.Controls;
using MainWinForm.Services;

namespace MainWinForm
{
	public partial class MainForm : Form
	{
		#region Data

		private ProjectSettings _projectSettings;
		private LogControler _logControler;
		private VideoPlayerControler _videoPlayerControler;

		private LogControl _log;
		private VideoPlayerControl _videoPlayer;
		private SettingsControl _settings;

		#endregion

		#region .ctor

		/// <summary>Запуск главной формы и привязка с контролерами.</summary>
		/// <param name="projectSettings">Контролер настроек.</param>
		/// <param name="logControler">Контролер лога.</param>
		/// <param name="videoPlayerControler">Контролер проигрывателя.</param>
		public MainForm(
			ProjectSettings projectSettings,
			LogControler logControler,
			VideoPlayerControler videoPlayerControler)
		{

			InitializeComponent();

			_projectSettings = projectSettings;
			_logControler = logControler;
			_videoPlayerControler = videoPlayerControler;

			_log = new LogControl(_logControler);
			_settings = new SettingsControl(_logControler, _projectSettings);
			_videoPlayer = new VideoPlayerControl(_logControler, _videoPlayerControler, _projectSettings);

			//Инициализируем наши контролы.
			_pnlPlayer.Controls.Add(_videoPlayer);
			_pnlSettings.Controls.Add(_settings);
			_pnlLog.Controls.Add(_log);

		}

		#endregion
	}
}
