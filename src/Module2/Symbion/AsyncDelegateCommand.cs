using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Symbion {
	public class AsyncDelegateCommand : ICommand {
		public event EventHandler CanExecuteChanged;

		private Predicate<object> _canExecute;
		private Action<object> _execute;
		private Action<Exception> _completed;
		private bool _running;

		public bool Running {
			get { return _running; }
		}

		public AsyncDelegateCommand(Action<object> execute, Action<Exception> completed) {
			_execute = execute; _completed = completed;
		}

		public AsyncDelegateCommand(Predicate<object> canExecute, Action<object> execute, Action<Exception> completed) {
			_canExecute = canExecute;
			_execute = execute;
			_completed = completed;
		}

		public bool CanExecute(object parameter) {
			if (_running) return false;
			if (_canExecute == null) return true;
			// return _canExecute.Invoke(parameter);
			return _canExecute(parameter);
		}

		private Task ExecuteAsync(object parameter) {
			var task = new Task(() => _execute(parameter));
			task.Start(); return task;
		}

		public async void Execute(object parameter) {
			//	if (_execute != null) _execute.Invoke(parameter);
			//	if (_execute != null) _execute(parameter);
			//	_execute?.Invoke(parameter);
			if (_running) return;
			_running = true;
			NotifyCanExecuteChanged();

			try {
				if (_execute != null) await ExecuteAsync(parameter);
				//	if (_completed != null) _completed(null);
				_completed?.Invoke(null);
			}
			catch (Exception ex) {
				//	if (_completed != null) _completed(ex);
				_completed?.Invoke(ex);
			}

			_running = false;
			NotifyCanExecuteChanged();

		}

		public void NotifyCanExecuteChanged() {
			//	if (CanExecuteChanged != null)	// not required for "event" delegates
			CanExecuteChanged(this, EventArgs.Empty);
		}
	}
}
