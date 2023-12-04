﻿using Symbion;
using System;

namespace Polymorphism1 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Before Create Logger");
			Console.WriteLine("--------------------");
			DebugHelper.ShowLoadedAssemblies();
			ILogger logger = LoggerFactory.CreateInstance();
			Console.WriteLine("After Create Logger");
			Console.WriteLine("-------------------");
			DebugHelper.ShowLoadedAssemblies();

			if (logger != null) {
				Console.WriteLine(logger.Source);
				logger.Write("This is the 1st message.", LogType.Information);
				logger.Write("This is the 2nd message.", LogType.Warning);
				logger.Write("This is the 3rd message.", LogType.Error);
				logger.Write("This is the 4th message.");
				logger.Message("Operation completed successfully.");
				logger.Warning("Operation may not have succeeded.");
				logger.Failure("Operation has failed.");
			}
			else {
				Console.WriteLine("Object doesn't support ILogger.");
			}
		}
	}
}
