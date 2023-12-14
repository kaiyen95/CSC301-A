using SymBank.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WCFHost2 {
	partial class MyService : ServiceBase {

		private ServiceHost _host;

		public MyService() {
			InitializeComponent();
		}

		protected override void OnStart(string[] args) {
			// TODO: Add code here to start your service.
			// if (_host != null) OnStop();
			if (_host == null) {
				_host = new ServiceHost(typeof(BankingServices));
				_host.Open();
			}
		}

		protected override void OnStop() {
			// TODO: Add code here to perform any tear-down necessary to stop your service.
			if (_host != null) {
				_host.Close();
				_host = null;
			}
		}
	}
}
