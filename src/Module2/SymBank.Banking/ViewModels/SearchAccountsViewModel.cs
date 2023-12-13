using SymBank.Banking.Models;
using SymBank.Banking.Services;
using Symbion;
using System;
using System.Collections.Generic;

namespace SymBank.Banking.ViewModels {
	public class SearchAccountsViewModel : BaseViewModel {
		private IAccountController _accountController;
		private List<Account> _results;
		private string _name;

		public string Name {
			get { return _name; }
			set {
				_name = value;
				NotifyPropertyChanged("Name");
			}
		}

		public List<Account> Results {
			get { return _results; }
			set {
				_results = value;
				NotifyPropertyChanged("Results");
			}
		}

		public void Search() {
			try {
				Results = _accountController.GetAccountsForName(_name);
				Shell.Status = $"Search completed. {_results.Count} items found.";
			}
			catch (Exception ex) {
				Shell.Failure("Error searching for accounts.\n" + ex.Message);
			}
		}

		// private List<Account> _tempResults;

		// this is executed using a separate (Task/thread). Cannot update UI
		//	use _tempResults to store the result temporarily or
		//	store into _results field directly so it doesn't trigger the property change notification
		private void StartSearch(object parameter) {
		//	_tempResults = _accountController.GetAccountsForName(_name);
			_results = _accountController.GetAccountsForName(_name);
		}

		// this is execute on the UI thread. Can update UI
		// assigns _tempResults to Results to update the UI
		//	fire property change notification on Results manually to update the UI
		private void SearchCompleted(Exception ex) {
			if (ex != null) Shell.Failure("Error searching for account.\n" + ex.Message);
			else {
				//Shell.Status = $"Search completed. {_tempResults.Count} items found.";
				//	Results = _tempResults;
				Shell.Status = $"Search completed. {_results.Count} items found.";
				NotifyPropertyChanged("Results");
			}
		}

		public AsyncDelegateCommand SearchCommand { get; private set; }


		public SearchAccountsViewModel() {
			SearchCommand = new AsyncDelegateCommand(StartSearch, SearchCompleted);
			_accountController = ServiceRepository.Get<IAccountController>();
			_name = string.Empty;
		}



	}
}
