using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SymBank.Shared.Commands {
	public static class MyCommands {
		//	public static readonly OpenBrowserCommand OpenBrowser = new OpenBrowserCommand();
		//public static readonly DelegateCommand OpenBrowser = new DelegateCommand(
		//		new Predicate<object>(OpenBrowser_CanExecute),
		//		new Action<object>(OpenBrowser_Execute)
		//	);

		//public static readonly DelegateCommand OpenBrowser = new DelegateCommand(
		//	OpenBrowser_CanExecute, OpenBrowser_Execute);

		//public static readonly DelegateCommand OpenBrowser = new DelegateCommand(
		//	delegate(object p) { return p != null; },
		//	delegate(object p) {
		//		var view = new WebBrowserView();
		//		view.Open(p.ToString());
		//		view.Show();
		//	});

		//	lambda expressions
		public static readonly ICommand OpenBrowser = new DelegateCommand(
			p => p != null,
			p => {
				var view = new WebBrowserView();
				view.Open(p.ToString());
				view.Show();
			});

		public static readonly ICommand Open = new DelegateCommand(
			p => p != null,	p => Process.Start(p.ToString()));

		//static bool OpenBrowser_CanExecute(object parameter) {
		//	return parameter != null;
		//}

		//static void OpenBrowser_Execute(object parameter) {
		//	var view = new WebBrowserView();
		//	view.Open(parameter.ToString());
		//	view.Show();
		//}
	}
}
