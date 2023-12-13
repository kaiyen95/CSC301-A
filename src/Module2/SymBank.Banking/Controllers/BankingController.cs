﻿using SymBank.Banking.Models;
using SymBank.Banking.Services;
using Symbion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SymBank.Banking.Controllers {
	//	[Service(ServiceType = typeof(IAccountController))]
	//	[Service(ServiceType = typeof(ITransactionController))]
	[Service(typeof(IAccountController))]
	[Service(typeof(ITransactionController))]
	public class BankingController :
		IAccountController,
		ITransactionController {

		private IAuthorization _auth;
		// private SymBankDataContext _dc;

		public BankingController() {
			_auth = ServiceRepository.Get<IAuthorization>();
		//	_dc = new SymBankDataContext();
		}

		public string UserName {
			get {
				//if (_auth == null)
				//	_auth = ServiceRepository.Get<IAuthorization>();
				return _auth.UserName;
			}
		}

		public void AddAccount(Account item) {
			var dc = new SymBankDataContext();
			//	dc.Accounts.InsertOnSubmit(item);
			//	dc.SubmitChanges();
			dc.AccountAdd(item.Code, item.Type, item.Name,
				item.ZipCode, UserName,
				DateTime.Now, item.Balance);
		}

		//public Task AddAccountAsync(Account item) {
		//	var task = new Task(() => {
		//		var dc = new SymBankDataContext();
		//		dc.AccountAdd(item.Code, item.Type, item.Name,
		//			item.ZipCode, UserName,
		//			DateTime.Now, item.Balance);
		//	});
		//	task.Start(); return task;
		//}

		public Task AddAccountAsync(Account item) {
			var task = new Task(() => AddAccount(item));
			task.Start(); return task;
		}

		// Withdrawal
		public int Credit(int source, decimal amount) {
			int? transactionCode = null;
			var dc = new SymBankDataContext();
			dc.AccountCredit(source, amount, UserName,
				DateTime.Now, ref transactionCode);
			return (int)transactionCode;
		}

		// Deposit
		public int Debit(int source, decimal amount) {
			int? transactionCode = null;
			var dc = new SymBankDataContext();
			dc.AccountDebit(source, amount, UserName,
				DateTime.Now, ref transactionCode);
			return (int)transactionCode;
		}

		public Account GetAccount(int code) {
			var dc = new SymBankDataContext();
			//	return dc.Accounts.Single(a => a.Code == code);
			var result = dc.Accounts.SingleOrDefault(a => a.Code == code);
			if (result == null) throw new Exception("Invalid account code.");
			return result;
		}

		public List<Account> GetAccountList() {
			var dc = new SymBankDataContext();
			return dc.Accounts.ToList();
		}

		public List<Account> GetAccountsForName(string name) {
			Thread.Sleep(6000);
			name = name.ToLower();
			var dc = new SymBankDataContext();
			//var query = from account in dc.Accounts
			//			where account.Name.ToLower().Contains(name)
			//			orderby account.Name
			//			select account;
			var query = dc.Accounts
				.Where(a => a.Name.ToLower().Contains(name))
				.OrderBy(a => a.Name);
			return query.ToList();
		}

		public Task<List<Account>> GetAccountsForNameAsync(string name) {
			var task = new Task<List<Account>>(() => GetAccountsForName(name));
			task.Start(); return task;
		}

		public int Transfer(int source, int target, decimal amount) {
			int? transactionCode = null;
			var dc = new SymBankDataContext();
			dc.AccountTransfer(source, target, amount, UserName,
				DateTime.Now, ref transactionCode);
			return (int)transactionCode;
		}
	}
}
