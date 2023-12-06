namespace Symbion {
	public class BaseService : IService {

		private static IShell _shell;

		public static IShell Shell {
			get {
				if (_shell == null)
					_shell = ServiceRepository.Get<IShell>();
				return _shell;
			}
		}


		//private string _serviceName;
		//public virtual string ServiceName {
		//	get { return _serviceName; }
		//	set { _serviceName = ServiceName; }
		//}

		//public BaseService() {
		//	ServiceName = this.GetType().Name;
		//}
	}
}
