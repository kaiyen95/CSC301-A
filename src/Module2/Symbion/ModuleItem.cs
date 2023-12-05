using System.Collections.Generic;
using System.Xml.Serialization;

namespace Symbion {
	[XmlType("Module")]
	public class ModuleItem {
		//public string Name { get; set; } = string.Empty;
		//public string Path { get; set; } = string.Empty;
		//public List<string> Roles { get; set; } = new List<string>();

		[XmlAttribute]
		public string Name { get; set; }
		[XmlAttribute]
		public string Path { get; set; }

		[XmlArrayItem("Role")]
		public List<string> Roles { get; set; }

		public ModuleItem() {
			Name = string.Empty;
			Path = string.Empty;
			Roles = new List<string>();
		}

	}
}
