using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainWinForm.Controls;

namespace MainWinForm.Services
{
	/// <summary>
	/// Класс модуля для регистрации типов.
	/// </summary>
	class MainFormModule : Module
	{
		#region Methods

		/// <summary>Загружает нужные типы.</summary>
		/// <param name="builder"></param>
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);

			builder
				.RegisterType<LogControler>()
				.AsSelf()
				.SingleInstance();

			builder
				.RegisterType<VideoPlayerControler>()
				.AsSelf()
				.SingleInstance();

			builder
				.RegisterType<ProjectSettings>()
				.AsSelf()
				.SingleInstance();
		}

		#endregion
	}
}
