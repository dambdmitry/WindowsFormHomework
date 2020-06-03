using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controls;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace MainWinForm.Controls
{
	public partial class VideoPlayerControl : UserControl
	{
		#region Data

		private LogControler _logControler;
		private VideoPlayerControler _videoPlayerControler;
		private ProjectSettings _projectSettings;

		//private Detector _detector = new Detector();

		#endregion

		#region .ctor

		/// <summary>Создает контрол и связывает его с контролерами. </summary>
		/// <param name="logControler">Контролер лога.</param>
		/// <param name="videoPlayerControler">Контролер проигрывателя.</param>
		/// <param name="projectSettings">Контролер настроек проекта.</param>
		public VideoPlayerControl(
			LogControler logControler,
			VideoPlayerControler videoPlayerControler,
			ProjectSettings projectSettings)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_logControler = logControler;
			_videoPlayerControler = videoPlayerControler;
			_projectSettings = projectSettings;

			_videoPlayerControler.ChangeImage += OnChangeImage;
			_videoPlayerControler.ChangeFrame += OnChangeFrame;

			_opnFileDialog.Filter = "Image|*.png; *.jpg|Video|*.mp4; *.avi;";

		}



		#endregion

		#region Handler

		/// <summary>Вызывается при каждом изменении кадра.</summary>
		/// <param name="image">Новый кадр.</param>
		private void OnChangeFrame(object sender, Mat image)
		{
			using(var img = new Mat())
			{
				if(!_projectSettings.IsDetector)
				{
					Cv2.Resize(image, img, new OpenCvSharp.Size(_picVideo.Width, _picVideo.Height), 0, 0, InterpolationFlags.Cubic);
					_picVideo.ImageIpl = img;
					_picVideo.Refresh();
				}
				//else
				//{
				//	Cv2.Resize(image, img, new OpenCvSharp.Size(_picVideo.Width, _picVideo.Height), 0, 0, InterpolationFlags.Cubic);
				//	_picVideo.Image = _detector.Detect(img).ToBitmap();
				//	_picVideo.Refresh();
				//}
			}
		}

		/// <summary>Вызывается при изменении картинки.</summary>
		private void OnChangeImage(object sender, string path)
		{
			try
			{
				_picVideo.Image = Image.FromFile(path);
			}
			catch(System.OutOfMemoryException)
			{
				_picVideo.Image = null;
				MessageBox.Show($"GDI+ не поддерживает формат файла {path} в пикселях.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		/// <summary>Вызывается при нажатии на кнопку "Открыть файл".</summary>
		private async void OnOpenFileClickAsync(object sender, EventArgs e)
		{
			if(_opnFileDialog.ShowDialog() == DialogResult.Cancel) return;

			if(_opnFileDialog.FilterIndex == (int)FilterType.Image)
			{
				_videoPlayerControler.OpenImage(_opnFileDialog.FileName);
			}
			else if(_opnFileDialog.FilterIndex == (int)FilterType.Video)
			{
				await _videoPlayerControler.OpenVideoAsync(_opnFileDialog.FileName);
			}
		}

		/// <summary>Вызывается при нажатии на кнопку "Открыть папку".</summary>
		private void OnOpenFolderClick(object sender, EventArgs e)
		{
			if(_opnFolderDialog.ShowDialog() == DialogResult.Cancel) return;
			_videoPlayerControler.OpenFolderWithImages(_opnFolderDialog.SelectedPath);
		}

		/// <summary>Вызывается при нажатии Следующая картинка ">>".</summary>
		private void OnNextClick(object sender, EventArgs e)
		{
			_videoPlayerControler.NextImage();
		}

		/// <summary>Вызывается при нажатии Предыдущая картинка "<<".</summary>
		private void OnPrevClick(object sender, EventArgs e)
		{
			_videoPlayerControler.PrevImage();
		}

		#endregion

		#region VideoHandler

		/// <summary>Вызывается при нажатии на "Старт".</summary>
		private async void OnStartClickAsync(object sender, EventArgs e)
		{
			await _videoPlayerControler.PlayVideoAsync();
		}

		/// <summary>Вызывается при нажатии на "Пауза".</summary>
		private async void OnPauseClickAsync(object sender, EventArgs e)
		{
			await _videoPlayerControler.PauseVideoAsync();
		}

		/// <summary>Вызывается при нажатии на "Стоп".</summary>
		private async void OnStopClickAsync(object sender, EventArgs e)
		{
			await _videoPlayerControler.StopVideoAsync();
		}

		#endregion
	}
}
