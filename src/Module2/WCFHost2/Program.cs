using System.ServiceProcess;

namespace WCFHost2 {
	class Program {
		static void Main(string[] args) {
			ServiceBase.Run(new MyService());
		}
	}
}
