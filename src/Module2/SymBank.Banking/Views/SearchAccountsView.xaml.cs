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
	/// Interaction logic for SearchAccountsView.xaml
	/// </summary>
	public partial class SearchAccountsView : BaseView {

		private IAccountController _accountController;

		public SearchAccountsView() {
			_accountController = ServiceRepository.Get<IAccountController>();
			InitializeComponent();
			Region = ShellRegions.SideRegion;
			Header = "Account Search";
		}

		private void BaseView_Loaded(object sender, RoutedEventArgs e) {
			txtSearch.Focus();
		}

		private async void btnSearch_Click(object sender, RoutedEventArgs e) {
			try {
				btnSearch.IsEnabled = false;
				var name = txtSearch.Text;
				var result = await _accountController.GetAccountsForNameAsync(name);
				lsbAccounts.ItemsSource = result;
			}
			catch (Exception ex) {
				Shell.Failure("Search account failed. " + ex.Message);
			}
			finally {
				btnSearch.IsEnabled = true;
				txtSearch.Focus();
			}
		}

		private void btnCancel_Click(object sender, RoutedEventArgs e) {
			Close();
		}
	}
}
