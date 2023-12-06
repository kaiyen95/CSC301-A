using SymBank.Banking.Controllers;
using SymBank.Banking.Services;
using SymBank.Banking.Views;
using SymBank.Shared.Commands;
using Symbion;

namespace SymBank.Banking {
	[ModuleClass]
	public class BankingModule : BaseModule {
		public override void Init() {
			base.Init(); // currently is empty but in the future there might be some code

			//var obj = new BankingController();
			//obj.Add<IAccountController>();
			//obj.Add<ITransactionController>();

			var mb = Shell.MenuBars["main"];
			var tb = Shell.ToolBars["main"];

			var menu = mb.GetMenu("menu_accounts");
			if (menu == null) {
				menu = mb.Create("menu_accounts", "_Accounts");
				mb.AddMenu(menu);
			}

			var addAccountCommand = new DelegateCommand(
				p => new AddAccountView().Show());
			var addAccountIcon = "/SymBank.Banking;component/Images/user_add.png";

			var addAccountMenuItem = mb.Create(
				"menuitem_addaccount", "_Add new Account",
				addAccountCommand, null, addAccountIcon);

			mb.AddItem(menu, addAccountMenuItem);


			var addAccountButton = tb.CreateButton(
				"button_addaccount", "Add new account",
				addAccountCommand, null, addAccountIcon);

			tb.AddSeparator();
			tb.AddItem(addAccountButton);

			mb.AddItem(menu,
				mb.Create(
					"menuitem_searchaccounts",
					"_Search for Accounts",
					new DelegateCommand(p => new SearchAccountsView().Show())));

				



			
		}
	}
}
