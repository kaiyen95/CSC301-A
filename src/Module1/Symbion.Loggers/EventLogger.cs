using System.Diagnostics;

namespace Symbion.Loggers {
	public class EventLogger : BaseLogger {
		#region methods
		public override void Write(string message, LogType logType = LogType.Information) {
			EventLogEntryType entryType;

			//EventLogEntryType entryType = EventLogEntryType.Information;
			//if (logType == LogType.Error) entryType = EventLogEntryType.Error;
			//else if (logType == LogType.Warning) entryType = EventLogEntryType.Warning;

			switch (logType) {
				case LogType.Warning: entryType = EventLogEntryType.Warning; break;
				case LogType.Error: entryType = EventLogEntryType.Error; break;
				default: entryType = EventLogEntryType.Information;	break;
			}
			EventLog.WriteEntry(Source, message, entryType);
		}
		#endregion
	}
}
