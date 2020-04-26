using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls
{
	/// <summary>
	/// Статичный класс для регистрации типов.
	/// </summary>
	public static class RegisterServices
	{
		/// <summary>
		/// Статичный метод, который регистрирует наши типы
		/// И возвращает уже построенный контейнер.
		/// </summary>
		public static IContainer Create()
		{
			var containerBuilder = new ContainerBuilder();

			//Регистрируем класс ProjectSettings и форму в контейнере.
			containerBuilder
				.RegisterType<ProjectSettings>()
				.AsSelf()
				.SingleInstance();

			containerBuilder
				.RegisterType<MainForm>()
				.AsSelf()
				.SingleInstance();

			return containerBuilder.Build();
		}
	}
}
