using Symbion;
using System;

namespace Serialization1 {
	class Program {
		static void Main(string[] args) {
			var list = new ModuleList();
			var item = new ModuleItem();
			item.Name = "SymBank.Banking.BankingModule";
			item.Path = "SymBank.Banking.dll";
			item.Roles.Add("Administrators");
			item.Roles.Add("Banking");
			list.Items.Add(item);
			list.Save(@"C:\CSC301-A\Modules.xml");


			list = ModuleList.Load(@"C:\CSC301-A\Modules.xml");
			Console.WriteLine(list.Items[0].Path);
		}
	}
}
