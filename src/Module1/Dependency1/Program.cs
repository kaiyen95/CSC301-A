using Symbion;

namespace Dependency1 {
	class Program {
		static void UseServices() {
			//	ILogger logger = (ILogger)ServiceRepository.Get(typeof(ILogger));
			var logger = ServiceRepository.Get<ILogger>();
			if (logger != null) {
				logger.Message("Hello!");
				logger.Message("Goodbye!");
			}
		}
		static void AddServices() {
			//	ServiceRepository.Add(typeof(ILogger), logger);
			//	ServiceRepository.Add<ILogger>(logger);
			//	ServiceRepository.Add(logger);
			//	logger.Add<ILogger>();
			//	ILogger logger = LoggerFactory.CreateInstance();
			//	logger.Add();
			//	new DebugLogger().Add<ILogger>();
			LoggerFactory.CreateInstance().Add();
		}
		static void Main(string[] args) {
			AddServices();
			UseServices();
		}
	}
}
