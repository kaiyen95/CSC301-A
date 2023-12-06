using System;
using System.Windows.Input;

namespace SymBank.Shared.Commands {
	public class DelegateCommand : ICommand {
		public event EventHandler CanExecuteChanged;

		public Predicate<object> _canExecute;
		public Action<object> _execute;

		public DelegateCommand(Action<object> execute) {
			_execute = execute;
		}

		public DelegateCommand(Predicate<object> canExecute, Action<object> execute) {
			_canExecute = canExecute;
			_execute = execute;
		}

		public bool CanExecute(object parameter) {
			if (_canExecute == null) return true;
			// return _canExecute.Invoke(parameter);
			return _canExecute(parameter);
		}

		public void Execute(object parameter) {
		//	if (_execute != null) _execute.Invoke(parameter);
		//	if (_execute != null) _execute(parameter);
			_execute?.Invoke(parameter);
		}

		public void NotifyCanExecuteChanged() {
		//	if (CanExecuteChanged != null)	// not required for "event" delegates
				CanExecuteChanged(this, EventArgs.Empty);
		}
	}
}
