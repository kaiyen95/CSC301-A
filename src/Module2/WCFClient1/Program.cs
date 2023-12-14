using SymBank.Services;
using System;
using System.ServiceModel;

namespace WCFClient1 {
	class Program {
		static void Main(string[] args) {
			//	var obj = new BankingServices();
			//	IAccountService service1 = obj;
			//	ITransactionService service2 = obj;
			IAccountService service1 = ChannelFactory<IAccountService>.CreateChannel(
				new BasicHttpBinding(), new EndpointAddress(
					"http://localhost:8080/symbank/services/account"));
			ITransactionService service2 = ChannelFactory<ITransactionService>.CreateChannel(
				new NetTcpBinding(), new EndpointAddress(
					"net.tcp://localhost:8081/symbank/services/transaction"));
			var list = service1.GetAccountList();
			foreach (var item in list)
				Console.WriteLine("{0},{1},{2}",
				item.Code, item.Name, item.Balance);
			int ref1 = service2.Debit(100, 1000m);
			int ref2 = service2.Credit(200, 500m);
			int ref3 = service2.Transfer(100, 200, 500m);
			Console.WriteLine(ref1);
			Console.WriteLine(ref2);
			Console.WriteLine(ref3);
		}
	}
}
