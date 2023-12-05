using SymBank.Banking.Services;
using Symbion;

namespace SymBank.Banking.Controllers {
//	[Service(ServiceType = typeof(IAccountController))]
//	[Service(ServiceType = typeof(ITransactionController))]
	[Service(typeof(IAccountController))]
	[Service(typeof(ITransactionController))]
	public class BankingController : 
		IAccountController,
		ITransactionController {

	}
}
