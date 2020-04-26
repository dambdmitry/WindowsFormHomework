using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls
{
	public class ProjectSettings
	{
		public string Path;
		public int Count;

		/// <summary>
		/// Конструктор класса.
		/// </summary>
		public ProjectSettings()
		{
			this.Path = "Какой-то путь";
			this.Count = 0;
		}
	}
}
