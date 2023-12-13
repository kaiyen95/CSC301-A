using SymBank.Banking.Models;
using SymBank.Banking.Services;
using SymBank.Shared;
using Symbion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SymBank.Banking.Views {
	/// <summary>
	/// Interaction logic for AddAccountView.xaml
	/// </summary>
	public partial class AddAccountView : BaseView {

		//private IAccountController _accountController;
		//private Account _account;

		public AddAccountView() {
			//_accountController = ServiceRepository.Get<IAccountController>();
			//	_account = new Account { Balance = 100m };
			//	DataContext = _account;
			InitializeComponent();
			//_account = (Account)DataContext;
			Region = ShellRegions.MainRegion;
			Header = "New Account";
		}

		private void BaseView_Loaded(object sender, RoutedEventArgs e) {
			txtCode.Focus();
		}

		//private void btnAdd_Click(object sender, RoutedEventArgs e) {
		//	try {
		//		_account.Name.NotNullOrEmpty("Account Name");
		//		_account.Name.Length.InRange("Length of name", 1, 30);
		//		_account.ZipCode.Matches("Zip code", @"^\d{5}$");
		//		_account.Balance.InRange("Balance", 100m, decimal.MaxValue);
		//		_accountController.AddAccount(_account);
		//		Shell.Success("Account added successfully.");
		//		Close();
		//		//_account = new Account() { Balance = 100m };
		//		//DataContext = _account;
		//		//txtCode.Focus();
		//	}
		//	catch (Exception ex) {
		//		Shell.Failure("Cannot add account." + ex.Message);
		//	}
		//}

		//private void btnCancel_Click(object sender, RoutedEventArgs e) {
		//	Close();
		//}
	}
}
