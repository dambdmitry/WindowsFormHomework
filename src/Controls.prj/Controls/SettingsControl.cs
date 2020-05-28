using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWinForm.Controls
{
	/// <summary>Контрол настроек проекта.</summary>
	public partial class SettingsControl : UserControl
	{
		#region Data

		private LogControler _logControler;
		private ProjectSettings _projectSettings;

		#endregion

		#region .ctor

		/// <summary> Создает контрол настроек и связывает его с контролером лога и контролером настроек.</summary>
		/// <param name="logControler">Контролер лога.</param>
		/// <param name="projectSettings">Контролер настроек.</param>
		public SettingsControl(
			LogControler logControler,
			ProjectSettings projectSettings)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_logControler = logControler;
			_projectSettings = projectSettings;

			_chkDetector.Checked = _projectSettings.IsDetector;
			_chkIsUnderCatalog.Checked = _projectSettings.IsUnderCatalog;
		}

		#endregion

		#region Methods

		/// <summary>Вызывается при изменении CheckBox'a "Детектор". </summary>
		private void OnChangeDetector(object sender, EventArgs e)
		{
			_projectSettings.IsDetector = _chkDetector.Checked;
		}

		/// <summary>Вызывается при изменении CheckBox'a "С подкаталогами". </summary>
		private void OnChangeUnderCatalog(object sender, EventArgs e)
		{
			_projectSettings.IsUnderCatalog = _chkIsUnderCatalog.Checked;
		}

		/// <summary>Сохраняет настройки проекта при нажатии на кнопку "Сохранить".</summary>
		private async void OnSaveClickAsync(object sender, EventArgs e)
		{
			await _projectSettings.SaveXMLAsync();
			_logControler.AddMessage("Настройки проекта сохранены");
		}

		#endregion
	}
}
