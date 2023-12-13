using SymBank.Banking.Models;
using SymBank.Banking.Services;
using Symbion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SymBank.Banking.ViewModels {
	public class AddAccountViewModel : BaseViewModel {
		private Account _account;
		private IAccountController _accountController;

		public Account Account {
			get {
				return _account;
			}
			set {
				_account = value;
				NotifyPropertyChanged("Account");
				AccountType = _account.Type;
			//	NotifyPropertyChanged("AccountType");
			//	NotifyPropertyChanged("AccountTypeBrush");
			}
		}

		public SolidColorBrush AccountTypeBrush {
			get {
				switch (_account.Type) {
					case 0: return Brushes.LightSteelBlue;
					case 1: return Brushes.Azure;
					case 2: return Brushes.Aqua;
					default: return Brushes.White;
				}
			}
		}

		public int AccountType {
			get {
				return _account.Type;
			}
			set {
				_account.Type = value;
				NotifyPropertyChanged("AccountType");
				NotifyPropertyChanged("AccountTypeBrush");
			}
		}

		public void Add() {
			try {
				_account.Name.NotNullOrEmpty("Account Name");
				_account.Name.Length.InRange("Length of name", 1, 30);
				_account.ZipCode.Matches("Zip code", @"^\d{5}$");
				_account.Balance.InRange("Balance", 100m, decimal.MaxValue);
				_accountController.AddAccount(_account);
				Shell.Success("Account added successfully.");
				//	CloseView();
				Account = new Account { Balance = 100m };
				//DataContext = _account;
				//txtCode.Focus();
			}
			catch (Exception ex) {
				Shell.Failure("Cannot add account." + ex.Message);
			}
		}

		public DelegateCommand AddCommand { get; private set; }

		public AddAccountViewModel() {
			AddCommand = new DelegateCommand(p => Add());
			_accountController = ServiceRepository.Get<IAccountController>();
			_account = new Account { Balance = 100m };
		}
	}
}
