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
	/// <summary>Лог контрол для печати сообщений в лог.</summary>
	public partial class LogControl : UserControl
	{
		#region Data

		private LogControler _logControler; //Контролер лога.

		#endregion

		#region .ctor

		/// <summary>Конструктор. Связывает Лог с его контролером. </summary>
		/// <param name="log">Контролер, который надо привязать к логу.</param>
		public LogControl(LogControler log)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_logControler = log;

			//Подписываем на событие, прописанное в LogControler.
			_logControler.AddMessageInLog += OnAddMessageInLog;
		}

		#endregion

		#region Methods

		private void OnAddMessageInLog(object sender, string text)
		{
			_txtLog.AppendText(text);
		}

		#endregion
	}
}
