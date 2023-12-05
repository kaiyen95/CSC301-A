using Symbion;
using System;
using System.Reflection;
using System.Security.Principal;

namespace Dependency1 {
	class Program {
		static void UseServices() {
			//	ILogger logger = (ILogger)ServiceRepository.Get(typeof(ILogger));
			var logger = ServiceRepository.Get<ILogger>();
			if (logger != null) {
				logger.Message("Hello!");
				logger.Message("Goodbye!");
			}
			var auth = ServiceRepository.Get<IAuthorization>();
			Console.WriteLine(auth.UserName);
			Console.WriteLine(auth.IsInRole("Everyone"));
			Console.WriteLine(auth.IsInRole("Administrators"));
			Console.WriteLine(auth.IsInRole("Banking"));
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
			new PrincipalAuthorization().Add<IAuthorization>();
		}
		static void Main(string[] args) {
			AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
			AddServices();
			UseServices();
			Console.Write("Press any key to close");
			Console.ReadKey();
		}
	}
}
