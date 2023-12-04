using System;
using System.IO;

namespace Symbion.Loggers {
	public class FileLogger : BaseLogger {
		#region fields
		private string _filename;
		#endregion
		public override string Source {
			get {
				return base.Source;
			}
			set {
				base.Source = value;
				_filename = Path.ChangeExtension(value, ".log");
			}
		}

		public override void Write(string message, LogType logType = LogType.Information) {
			string text = $"\"{DateTime.UtcNow}\",\"{logType}\",\"{message}\"\r\n";
			File.AppendAllText(_filename, text);
		}
	}
}
