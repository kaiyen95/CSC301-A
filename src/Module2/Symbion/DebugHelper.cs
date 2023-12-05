using System;
using System.Diagnostics;
using System.Reflection;

namespace Symbion {
	public static class DebugHelper {
		[Conditional("DEBUG")]
		public static void ShowLoadedAssemblies() {
			AppDomain domain = AppDomain.CurrentDomain;
			Assembly[] assemblies = domain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
				Console.WriteLine(assembly.FullName);
		}
	}
}
