using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Symbion {
	public class DebugLogger {
		#region fields
		private string _source;
		#endregion
		#region properties
		public string Source {
			get {
				return _source;
			}
			set {
				Debug.Assert(!string.IsNullOrEmpty(value),
					"Source cannot be null or empty.");
				_source = value;
			}
		}
		#endregion
		#region constructors
		public DebugLogger() {
			Assembly assembly = Assembly.GetEntryAssembly();
			Source = Path.GetFileNameWithoutExtension(assembly.Location);
		}
		#endregion
		#region methods
		public void Write(string message, LogType logType = LogType.Information) {
		//	Debug.WriteLine(string.Format("[{0}] {1}(\"{2}\"", _source, logType, message));
			Debug.WriteLine($"[{_source}] {logType}(\"{message}\")");
		}
		public void Message(string message) {
			Write(message, LogType.Information);
		}
		public void Warning(string message) {
			Write(message, LogType.Warning);
		}
		public void Failure(string message) {
			Write(message, LogType.Error);
		}
		#endregion
	}
}
