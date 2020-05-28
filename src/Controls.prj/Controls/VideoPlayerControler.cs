using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;

namespace MainWinForm.Controls
{
	/// <summary>Класс функционала контрола проигрывателя. </summary>
	public class VideoPlayerControler
	{
		#region Data

		private ProjectSettings _projectSettings;
		private LogControler _logControler;

		private List<string> _listImages;
		private int _currentImage;
		private int _countImages;

		private VideoCapture _capture;
		private int _fps;
		private bool _pause;
		private string _stopedFile;

		#endregion

		#region .ctor

		/// <summary>Создает контролер проигрывателя и связывает его контролером настроек.</summary>
		/// <param name="projectSettings">Контролер настроек</param>
		public VideoPlayerControler(ProjectSettings projectSettings, LogControler logControler)
		{
			_projectSettings = projectSettings;
			_logControler = logControler;
		}

		#endregion

		#region Events

		/// <summary>Вызывается при изменении картинки. </summary>
		public event EventHandler<string> ChangeImage;

		/// <summary>Вызывается при изменении кадра. </summary>
		public event EventHandler<Mat> ChangeFrame;

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

		/// <summary>Обработчик события изменения кадра.</summary>
		/// <param name="image">Кадр.</param>
		private void OnChangeFrame(Mat image)
		{
			if(ChangeFrame != null)
			{
				ChangeFrame.Invoke(null, image);
			}
		}

		#endregion

		#region ImageMethods

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
					.Where(s => s.ToLower().EndsWith(".png") || s.ToLower().EndsWith(".jpg") || s.ToLower().EndsWith(".bmp") || s.ToLower().EndsWith(".jpeg"));
			}
			else
			{
				fileDirectory = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly)
					.Where(s => s.ToLower().EndsWith(".png") || s.ToLower().EndsWith(".jpg") || s.ToLower().EndsWith(".bmp") || s.ToLower().EndsWith(".jpeg"));
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
				MessageBox.Show("В директории нет файлов с нужным расширением \n(.png, .jpg, .bmp, .jpeg)", "Внимание",
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

		#region VideoMethods

		/// <summary>Открывает видеофайл.</summary>
		/// <param name="path">Путь к файлу.</param>
		public async Task OpenVideoAsync(string path)
		{
			if(_capture != null) _capture.Dispose();
			_stopedFile = path;
			_capture = new VideoCapture(path);
			//_fps = (int)(1000 / _capture.Fps);
			_fps = 1; // При таком значении видео воспроизводится в нормальном режиме, при 60 происходит слоумо.
			using(Mat image = new Mat())
			{
				_capture.Read(image);
				if(!image.Empty())
				{
					await NextFrameAddInVideoControlAsync(image);
				}
				else
				{
					_logControler.AddMessage("Некорректное видео");
				}
			}
		}

		/// <summary>Запускает видео</summary>
		public async Task PlayVideoAsync()
		{
			_pause = false;
			while(true)
			{
				if(_capture != null)
				{
					if(!_pause)
					{
						using(Mat image = new Mat())
						{
							_capture.Read(image);
							if(image.Empty())
							{
								_logControler.AddMessage("Конец видео");
								break;
							}
							await NextFrameAddInVideoControlAsync(image);
							await Task.Delay(_fps);
							//Cv2.WaitKey(_fps);
						}
					}
					else
					{
						break;
					}
				}
				else
				{
					break;
				}
			}
		}

		/// <summary>Ставит видео на паузу.</summary>
		public async Task PauseVideoAsync()
		{
			await Task.Run(() =>
			{
				if(_capture != null) _pause = true;
			});
		}

		/// <summary>Останавливает видео и возвращает его на первый кадр.</summary>
		public async Task StopVideoAsync()
		{
			_pause = true;
			await OpenVideoAsync(_stopedFile);
		}

		/// <summary>Добавляет следующий кадр на контрол.</summary>
		/// <param name="image">Кадр.</param>
		private async Task NextFrameAddInVideoControlAsync(Mat image)
		{
			OnChangeFrame(image);
		}

		#endregion

	}


}
