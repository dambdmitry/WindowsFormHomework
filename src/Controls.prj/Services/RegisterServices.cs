using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWinForm.Services
{
	/// <summary> Статичный класс для регистрации типов.</summary>
	public static class RegisterServices
	{
		#region Methods

		/// <summary>
		/// Статичный метод, который регистрирует наши типы
		/// И возвращает уже построенный контейнер.
		/// </summary>
		public static IContainer Create()
		{
			var containerBuilder = new ContainerBuilder();

			//Регистрируем класс Модуль формы и саму форму в контейнере.
			containerBuilder.RegisterModule<MainFormModule>();

			containerBuilder
				.RegisterType<MainForm>()
				.AsSelf()
				.SingleInstance();

			return containerBuilder.Build();
		}

		#endregion
	}
}
