﻿using Symbion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows;

namespace SymBank {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class MyApp : Application {
		private void Application_Startup(object sender, StartupEventArgs e) {
			AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
			new PrincipalAuthorization().Add<IAuthorization>();
			LoggerFactory.CreateInstance().Add();
			ModuleLoader.Load("Modules.xml");
		}

		private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e) {
			if (Debugger.IsAttached) Debugger.Break(); else {
				var log = ServiceRepository.Get<ILogger>();
				if (log != null) log.Failure(e.Exception.ToString());
			}
		}

		private void Application_Exit(object sender, ExitEventArgs e) {
			ModuleLoader.Exit();
		}
	}
}
