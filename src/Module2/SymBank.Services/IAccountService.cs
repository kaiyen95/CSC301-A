using System.Collections.Generic;
using System.ServiceModel;

namespace SymBank.Services {
	[ServiceContract]
	public interface IAccountService {
		[OperationContract]void AddAccount(Account item);
		[OperationContract]Account GetAccount(int code);
		[OperationContract]List<Account> GetAccountList();
		[OperationContract]List<Account> GetAccountsForName(string name);
	}
}
