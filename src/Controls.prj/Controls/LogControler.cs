using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWinForm.Controls
{
	/// <summary>Класс функционала Лога.</summary>
	public class LogControler
	{
		#region Data

		private string _path = "Logs\\Log.txt"; //Путь куда сохраним файл с логами.

		#endregion

		#region .ctor
		/// <summary>Создает контролер и вместе с ним папку, в которой будет файл с логами.</summary>
		public LogControler()
		{
			var directoryLog = new DirectoryInfo($"Logs");
			IsDirectoryExist(directoryLog);
		}

		#endregion

		#region Events

		/// <summary>Событие, которое вызывается при добавлении сообщения в лог.</summary>
		public event EventHandler<string> AddMessageInLog;

		#endregion

		#region Handler

		/// <summary>Обработчик события добавления сообщения в лог.</summary>
		/// <param name="text">Текст добавляемого сообщения.</param>
		private void OnAddMessageInLog(string text)
		{
			if(AddMessageInLog != null)
			{
				AddMessageInLog.Invoke(null, text);
			}
		}

		#endregion

		#region Methods

		/// <summary>Добавляет сообщение в лог.</summary>
		/// <param name="text">Текст сообщения.</param>
		public void AddMessage(string text)
		{
			var msg = $"[{DateTime.Now}] - " + text + "\n";
			OnAddMessageInLog(msg);
			SaveLogInFileAsync(msg);
		}

		/// <summary>Сохранение лога в файл. </summary>
		/// <param name="text">Текст лога</param>
		public async void SaveLogInFileAsync(string text)
		{
			using(FileStream fileStreamWriter = new FileStream(_path, FileMode.Append))
			{
				byte[] bytes = Encoding.Default.GetBytes(text);
				await fileStreamWriter.WriteAsync(bytes, 0, bytes.Length);
			}
		}

		/// <summary>Существует ли каталог, если не существует, то создает такой. </summary>
		/// <param name="directoryInfo">Информация о директории.</param>
		public void IsDirectoryExist(DirectoryInfo directoryInfo)
		{
			if(!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
		}

		#endregion
	}
}
