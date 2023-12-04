namespace Symbion {
	public interface ILogger {
		string Source { get; set; }
		void Write(string message,
			LogType logType = LogType.Information);
		void Message(string message);
		void Warning(string message);
		void Failure(string message);
	}
}
