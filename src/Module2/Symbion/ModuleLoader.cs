using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Symbion {
	public static class ModuleLoader {
		#region fields
		private static List<IModule> _modules;
		#endregion
		#region constructors
		static ModuleLoader() {
			_modules = new List<IModule>();
		}
		#endregion
		#region methods
		public static void Load(string path) {
			ILogger logger = ServiceRepository.Get<ILogger>();
			IAuthorization auth = ServiceRepository.Get<IAuthorization>();
			Debug.Assert(logger != null, "Logger service required by module loader.");
			Debug.Assert(auth != null, "Authorization service required by module loader.");
			ModuleList list = ModuleList.Load(path);
			foreach (ModuleItem item in list.Items) {
				if (item.Roles.Count > 0 && !auth.IsInAnyRoles(item.Roles)) {
					Debug.WriteLine($"User is not authorized for module {item.Path}.");
					continue;
				}
				if (!File.Exists(item.Path)) {
					logger.Failure($"Cannot locate module {item.Path}.");
					continue;
				}
				Assembly assembly = null;
				try {
					assembly = Assembly.LoadFrom(item.Path);
				}
				catch (Exception ex) {
					logger.Failure(
						$"Error '{ex.Message}' occurred " +
						$"loading module {item.Path}.");
					continue;
				}

				Type moduleType = assembly.GetType(item.Name);
				if (moduleType == null) {
					Type[] types = assembly.GetExportedTypes();
					foreach (Type type in types) {
						if (!type.IsClass) continue;
						var attribute = type.GetCustomAttribute<ModuleClassAttribute>();
						if (attribute != null) moduleType = type;
					}
					if (moduleType == null) {
						logger.Failure($"Cannot find module class in module {item.Path}.");
						continue;
					}
				}

				try {
					//	IModule instance = (IModule)Activator.CreateInstance(moduleType);
					//	_modules.Add(instance);
					_modules.Add((IModule)Activator.CreateInstance(moduleType));
					Debug.WriteLine($"Module {item.Path} loaded successfully.");
				}
				catch (Exception ex) {
					logger.Failure($"Error '{ex.Message}' instancing {item.Name} in module {item.Path}.");
					continue;
				}
			}
		}
		public static void Init() {
			foreach (IModule module in _modules) {
				module.Init();
				module.AddServices();
			}

		}
		public static void Exit() {
			foreach (IModule module in _modules)
				module.Exit();
		}
		#endregion
	}
}
