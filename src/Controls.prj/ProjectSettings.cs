using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MainWinForm
{
	/// <summary>Класс, хранящий настройки проекта.</summary>
	public class ProjectSettings
	{
		#region Data

		private string _pathXML = "project.xml";

		#endregion

		#region Properties

		/// <summary>Указывает: используется ли детектор.</summary>
		public bool IsDetector { get; set; }

		/// <summary>Указывает: открывать ли папки с подкаталогами. </summary>
		public bool IsUnderCatalog { get; set; }

		#endregion

		#region .ctor

		/// <summary>Подгружает настройки проекта.</summary>
		public ProjectSettings()
		{
			InitSettings();
		}

		#endregion

		#region Methods

		/// <summary>Сохраняет настройки проекта.</summary>
		public void SaveXML()
		{
			XElement bufElement; //Элемент для записи.

			XDocument xDoc = new XDocument();

			XElement project = new XElement("MainWinForm");

			bufElement = new XElement("IsDetector", IsDetector);
			project.Add(bufElement);

			bufElement = new XElement("IsUnderCatalog", IsUnderCatalog);
			project.Add(bufElement);

			xDoc.Add(project);

			xDoc.Save(_pathXML);
		}

		/// <summary>Загружает настройки проекта.</summary>
		public void LoadXML()
		{
			XDocument xDoc = XDocument.Load(_pathXML);

			IsDetector = bool.Parse(xDoc.Root.Element("IsDetector").Value);
			IsUnderCatalog = bool.Parse(xDoc.Root.Element("IsUnderCatalog").Value);
		}

		public void InitSettings()
		{
			if(File.Exists(_pathXML))
			{
				LoadXML();
			}
			else
			{
				IsDetector = false;
				IsUnderCatalog = false;
			}
		}
		#endregion
	}
}
