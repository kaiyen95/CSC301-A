using System.ComponentModel;

namespace Symbion {
	public class BaseViewModel : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propertyName) {
			if (PropertyChanged != null) PropertyChanged(this,
				new PropertyChangedEventArgs(
					propertyName));
		}

		private static IShell _shell;
		public static IShell Shell {
			get {
				return _shell ?? (_shell = ServiceRepository.Get<IShell>());
			}
		}

		private BaseView _view;

		public BaseView View {
			get { return _view; }
			set { _view = value; }
		}

		public void CloseView() {
			if (_view != null) _view.Close();
		}

		public DelegateCommand CloseViewCommand { get; private set; }

		public BaseViewModel() {
			CloseViewCommand = new DelegateCommand(p => CloseView());
		}
	}
}
