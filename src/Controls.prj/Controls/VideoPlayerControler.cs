using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWinForm.Controls
{
	/// <summary>Класс функционала контрола проигрывателя. </summary>
	public class VideoPlayerControler
	{
		#region Data

		private ProjectSettings _projectSettings;

		private List<string> _listImages;
		private int _currentImage;
		private int _countImages;

		#endregion

		#region .ctor

		/// <summary>Создает контролер проигрывателя и связывает его контролером настроек.</summary>
		/// <param name="projectSettings">Контролер настроек</param>
		public VideoPlayerControler(ProjectSettings projectSettings)
		{
			_projectSettings = projectSettings;
		}

		#endregion

		#region Events

		/// <summary>Вызывается при изменении картинки. </summary>
		public event EventHandler<string> ChangeImage;

		#endregion

		#region Handler

		/// <summary>Обработчик события изменения картинки.</summary>
		/// <param name="path">Путь к картинке.</param>
		private void OnChangeImage(string path)
		{
			if(ChangeImage != null)
			{
				ChangeImage.Invoke(null, path);
			}
		}

		#endregion

		#region Methods

		/// <summary>Открывает картинку.</summary>
		/// <param name="path">Путь к картинке.</param>
		public void OpenImage(string path)
		{
			AddImageOnControl(path);
		}

		/// <summary>Добавляет картинку на контрол. </summary>
		/// <param name="path">Путь к картинке.</param>
		private void AddImageOnControl(string path)
		{
			OnChangeImage(path);
		}

		/// <summary>Открывает папку с картинками. </summary>
		/// <param name="path">Путь к папке.</param>
		public void OpenFolderWithImages(string path)
		{
			IEnumerable<string> fileDirectory = null;

			if(_projectSettings.IsUnderCatalog)
			{
				fileDirectory = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
					.Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp") || s.EndsWith(".jpeg"));
			}
			else
			{
				fileDirectory = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly)
					.Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp") || s.EndsWith(".jpeg"));
			}

			_listImages = fileDirectory.ToList();
			_currentImage = 0;
			_countImages = fileDirectory.Count();

			//Проверим, что есть хотя бы один файл с доступным расширением.
			if(_countImages != 0)
			{
				AddImageOnControl(_listImages[_currentImage]);
			}
			else
			{
				MessageBox.Show("В директории нет файлов с нужным расширением \n(.png; .jpg; .bmp; .jpeg)", "Внимание",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>Переход на следущую картинку.</summary>
		public void NextImage()
		{
			if(_listImages != null && _listImages.Count() != 0)
			{
				_currentImage++;
				if(_currentImage == _countImages)
				{
					_currentImage = 0;
				}
				AddImageOnControl(_listImages[_currentImage]);
			}
		}

		/// <summary>Переход на предыдущую картинку. </summary>
		public void PrevImage()
		{
			if(_listImages != null && _listImages.Count != 0)
			{
				_currentImage--;
				if(_currentImage < 0)
				{
					_currentImage = _countImages - 1;
				}
				AddImageOnControl(_listImages[_currentImage]);
			}
		}

		#endregion
	}


}
