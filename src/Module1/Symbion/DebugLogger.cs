using System.Diagnostics;

namespace Symbion {
	public sealed class DebugLogger : BaseLogger {

		public override void Write(string message, LogType logType = LogType.Information) {
			//	Debug.WriteLine(string.Format("[{0}] {1}(\"{2}\"", _source, logType, message));
			Debug.WriteLine($"[{Source}] {logType}(\"{message}\")");
		}
	}
}
