using SymBank.Banking.Controllers;
using SymBank.Banking.Services;
using Symbion;

namespace SymBank.Banking {
	[ModuleClass]
	public class BankingModule : BaseModule {
		public override void Init() {
			base.Init(); // currently is empty but in the future there might be some code

			//var obj = new BankingController();
			//obj.Add<IAccountController>();
			//obj.Add<ITransactionController>();

		}
	}
}
