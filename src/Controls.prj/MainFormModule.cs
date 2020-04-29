using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls
{
	/// <summary>
	/// Класс модуля для последующей регистрации типов.
	/// </summary>
	class MainFormModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);

			builder
				.RegisterType<ProjectSettings>()
				.AsSelf()
				.SingleInstance();
		}
	}
}
