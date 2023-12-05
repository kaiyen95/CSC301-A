using Symbion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Modules1 {
	class Class1 {
		// property injection
		// [Inject]
		public ILogger Logger { get; set; }
		//	private ILogger _logger;
		public Class1() {  }
		// constructor injection
		//public Class1(ILogger logger) {
		//	_logger = ServiceRepository.Get<ILogger>();
		//_logger = logger;
		//}
	}
	class Program {
		static void Main(string[] args) {
			AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
			new PrincipalAuthorization().Add<IAuthorization>();
			LoggerFactory.CreateInstance().Add();
			ModuleLoader.Load("Modules.xml");
			ModuleLoader.Init();

			//	retrieve and use services
			//	Class1 obj = ServiceRepository.CreateInstance<Class1>();


			ModuleLoader.Exit();
		}
	}
}
