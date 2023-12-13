using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;

namespace SymBank.Services {
	public class BankingServices :
		IAccountService,
		ITransactionService {

		public string UserName {
			get {
				return Thread.CurrentPrincipal.Identity.Name;
			}
		}

		public void AddAccount(Account item) {
			try {
				var dc = new SymBankDataContext();
				dc.AccountAdd(item.Code, item.Type, item.Name,
					item.ZipCode, UserName,
					DateTime.Now, item.Balance);
			}
			catch (Exception ex) {
				throw new FaultException("Add account failed. " + ex.Message);
			}
		}

		public int Credit(int source, decimal amount) {
			try {
			}
			catch (Exception ex) {
				throw new FaultException("Credit account failed. " + ex.Message);
			}
			int? transactionCode = null;
			var dc = new SymBankDataContext();
			dc.AccountCredit(source, amount, UserName,
				DateTime.Now, ref transactionCode);
			return (int)transactionCode;
		}

		public int Debit(int source, decimal amount) {
			try {
				int? transactionCode = null;
				var dc = new SymBankDataContext();
				dc.AccountDebit(source, amount, UserName,
					DateTime.Now, ref transactionCode);
				return (int)transactionCode;

			}
			catch (Exception ex) {
				throw new FaultException("Debit account failed. " + ex.Message);
			}
		}

		public Account GetAccount(int code) {
			try {
				var dc = new SymBankDataContext();
				//	return dc.Accounts.Single(a => a.Code == code);
				var result = dc.Accounts.SingleOrDefault(a => a.Code == code);
				if (result == null) throw new Exception("Invalid account code.");
				return result;
			}
			catch (Exception ex) {
				throw new FaultException("Get account failed. " + ex.Message);
			}
		}

		public List<Account> GetAccountList() {
			try {
				var dc = new SymBankDataContext();
				return dc.Accounts.ToList();
			}
			catch (Exception ex) {
				throw new FaultException("Get account list failed. " + ex.Message);
			}
		}

		public List<Account> GetAccountsForName(string name) {
			try {
				Thread.Sleep(6000);
				name = name.ToLower();
				var dc = new SymBankDataContext();
				var query = dc.Accounts
					.Where(a => a.Name.ToLower().Contains(name))
					.OrderBy(a => a.Name);
				return query.ToList();
			}
			catch (Exception ex) {
				throw new FaultException("Search account list failed. " + ex.Message);
			}
		}

		public int Transfer(int source, int target, decimal amount) {
			try {
				int? transactionCode = null;
				var dc = new SymBankDataContext();
				dc.AccountTransfer(source, target, amount, UserName,
					DateTime.Now, ref transactionCode);
				return (int)transactionCode;
			}
			catch (Exception ex) {
				throw new FaultException("Account transfer failed. " + ex.Message);
			}
		}
	}
}
