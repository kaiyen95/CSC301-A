using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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
			var dc = new SymBankDataContext();
			try {
				dc.AccountAdd(item.Code, item.Type, item.Name,
					item.ZipCode, UserName,
					DateTime.Now, item.Balance);
			}
			catch (Exception ex) {
				throw new FaultException("Add account failed. " + ex.Message);
			}
			finally {
				dc.Dispose();
			}
		}

		public int Credit(int source, decimal amount) {
			var dc = new SymBankDataContext();
			try {
				int? transactionCode = null;
				dc.AccountCredit(source, amount, UserName,
					DateTime.Now, ref transactionCode);
				return (int)transactionCode;
			}
			catch (Exception ex) {
				throw new FaultException("Credit account failed. " + ex.Message);
			}
			finally {
				dc.Dispose();
			}
		}

		public int Debit(int source, decimal amount) {
			var dc = new SymBankDataContext();
			try {
				int? transactionCode = null;
				dc.AccountDebit(source, amount, UserName,
					DateTime.Now, ref transactionCode);
				return (int)transactionCode;

			}
			catch (Exception ex) {
				throw new FaultException("Debit account failed. " + ex.Message);
			}
			finally {
				dc.Dispose();
			}
		}

		public Account GetAccount(int code) {
			var dc = new SymBankDataContext();
			try {
				//	return dc.Accounts.Single(a => a.Code == code);
				var result = dc.Accounts.SingleOrDefault(a => a.Code == code);
				if (result == null) throw new Exception("Invalid account code.");
				return result;
			}
			catch (Exception ex) {
				throw new FaultException("Get account failed. " + ex.Message);
			}
			finally {
				dc.Dispose();
			}
		}

		private void CheckSecurity() {
			var principal = Thread.CurrentPrincipal;
			if (!(principal.IsInRole("Banking") || principal.IsInRole("Administrators")))
				throw new FaultException("You do not have permission for this operation.");
		}

		//		[PrincipalPermission(SecurityAction.Demand, Role = "Banking")]
		//		[PrincipalPermission(SecurityAction.Demand, Role = "Administrators")]
		public List<Account> GetAccountList() {
			CheckSecurity();
			var dc = new SymBankDataContext();
			try {
				return dc.Accounts.ToList();
			}
			catch (Exception ex) {
				throw new FaultException("Get account list failed. " + ex.Message);
			}
			finally {
				dc.Dispose();
			}
		}

		public List<Account> GetAccountsForName(string name) {
			var dc = new SymBankDataContext();
			try {
				Thread.Sleep(6000);
				name = name.ToLower();
				var query = dc.Accounts
					.Where(a => a.Name.ToLower().Contains(name))
					.OrderBy(a => a.Name);
				return query.ToList();
			}
			catch (Exception ex) {
				throw new FaultException("Search account list failed. " + ex.Message);
			}
			finally {
				dc.Dispose();
			}
		}

		public int Transfer(int source, int target, decimal amount) {
			var dc = new SymBankDataContext();
			try {
				int? transactionCode = null;
				dc.AccountTransfer(source, target, amount, UserName,
					DateTime.Now, ref transactionCode);
				return (int)transactionCode;
			}
			catch (Exception ex) {
				throw new FaultException("Account transfer failed. " + ex.Message);
			}
			finally {
				dc.Dispose();
			}
		}
	}
}
