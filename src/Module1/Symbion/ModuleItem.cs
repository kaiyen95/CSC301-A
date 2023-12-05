using System.Collections.Generic;

namespace Symbion {
	public class ModuleItem {
		//public string Name { get; set; } = string.Empty;
		//public string Path { get; set; } = string.Empty;
		//public List<string> Roles { get; set; } = new List<string>();

		public string Name { get; set; }
		public string Path { get; set; }
		public List<string> Roles { get; set; }

		public ModuleItem() {
			Name = string.Empty;
			Path = string.Empty;
			Roles = new List<string>();
		}

	}
}
