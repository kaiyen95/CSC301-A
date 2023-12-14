using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WCFClient2.SymBank.Services.Client;

namespace WCFClient2 {
	class Program {
		//static Task<Account[]> GetAccountListAsync() {
		//	var task = new Task<Account[]>(() => {
		//		IAccountService service1 = new AccountServiceClient("http_account");
		//		return service1.GetAccountList();
		//	});
		//	task.Start(); return task;
		//}
		static async Task MainAsync() {
			IAccountService service1 = new AccountServiceClient("http_account");
			ITransactionService service2 = new TransactionServiceClient("http_transaction");
			//	var list = service1.GetAccountList();
			var list = await service1.GetAccountListAsync();
			foreach (var item in list)
				Console.WriteLine("{0},{1},{2}",
				item.Code, item.Name, item.Balance);
			//int ref1 = service2.Debit(100, 1000m);
			//int ref2 = service2.Credit(200, 500m);
			//int ref3 = service2.Transfer(100, 200, 500m);
			int ref1 = await service2.DebitAsync(100, 1000m);
			int ref2 = await service2.CreditAsync(200, 500m);
			int ref3 = await service2.TransferAsync(100, 200, 500m);
			Console.WriteLine(ref1);
			Console.WriteLine(ref2);
			Console.WriteLine(ref3);
		}
		static void Main(string[] args) {
			var task = MainAsync();
			task.Wait();
		}
	}
}
