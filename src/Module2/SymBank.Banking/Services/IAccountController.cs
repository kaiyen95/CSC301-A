using SymBank.Banking.Models;
using Symbion;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SymBank.Banking.Services {
	public interface IAccountController : IService {
	//	[Obsolete("Use AddAccountAsync instead.")]
		void AddAccount(Account item);
		Account GetAccount(int code);
		List<Account> GetAccountList();
		List<Account> GetAccountsForName(string name);

		Task AddAccountAsync(Account item);
	//	Task<Account> GetAccountAsync(int code);
	//	Task<List<Account>> GetAccountListAsync();
		Task<List<Account>> GetAccountsForNameAsync(string name);
	}
}
