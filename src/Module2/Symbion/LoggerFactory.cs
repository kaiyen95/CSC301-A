using System;
using System.Configuration;

namespace Symbion {
	public static class LoggerFactory {
		#region consts
		public const string DefaultLogger = "Symbion.DebugLogger; Symbion";
		#endregion
		#region fields
		private readonly static string _typeName;
		private readonly static string _assemblyName;
		#endregion
		#region constructors
		static LoggerFactory() {
			string key = typeof(ILogger).FullName;
			//	string value = Environment.GetEnvironmentVariable(key);
			string value = ConfigurationManager.AppSettings[key];
			if (value == null) value = DefaultLogger;
			string[] fields = value.Split(';');
			_typeName = fields[0].Trim();
			_assemblyName = fields[1].Trim();
		}
		#endregion
		#region methods
		public static ILogger CreateInstance() {
			return (ILogger)Activator.CreateInstance(
				_assemblyName, _typeName).Unwrap();
		}
		#endregion
	}
}
