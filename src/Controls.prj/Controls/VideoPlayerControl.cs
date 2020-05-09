using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls;

namespace MainWinForm.Controls
{
	public partial class VideoPlayerControl : UserControl
	{
		#region Data

		private LogControler _logControler;
		private VideoPlayerControler _videoPlayerControler;
		private ProjectSettings _projectSettings;

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

			_opnFileDialog.Filter = "Image|*.png; *.jpg|Video|*.mp4; *.avi;";
		}

		#endregion

		#region Handler

		/// <summary>Вызывается при изменении картинки.</summary>
		private void OnChangeImage(object sender, string path)
		{
			_picVideo.Image = Image.FromFile(path);
		}

		/// <summary>Вызывается при нажатии на кнопку "Открыть файл".</summary>
		private void OnOpenFileClick(object sender, EventArgs e)
		{
			if(_opnFileDialog.ShowDialog() == DialogResult.Cancel) return;

			if(_opnFileDialog.FilterIndex == (int)FilterType.Image)
			{
				_videoPlayerControler.OpenImage(_opnFileDialog.FileName);
			}
			else if(_opnFileDialog.FilterIndex == (int)FilterType.Video)
			{

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
	}
}
