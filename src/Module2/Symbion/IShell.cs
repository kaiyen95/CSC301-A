﻿using System.Collections.Generic;

namespace Symbion {
	public interface IShell : IService {
		object Status { set; }
		void Success(string message);
		void Failure(string message);

		Dictionary<string, IRegionAdapter> Regions { get; }
		Dictionary<string, MenuBarBuilder> MenuBars { get; }
		Dictionary<string, ToolBarBuilder> ToolBars { get; }
	}
}
