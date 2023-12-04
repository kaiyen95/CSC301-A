using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Symbion {
	public abstract class BaseLogger : BaseService, ILogger {
		#region fields
		private string _source;
		#endregion
		#region properties
		public virtual string Source {
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
		public BaseLogger() {
			Assembly assembly = Assembly.GetEntryAssembly();
			Source = Path.GetFileNameWithoutExtension(assembly.Location);
		}
		#endregion
		#region methods
		public abstract void Write(string message, LogType logType = LogType.Information);
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
