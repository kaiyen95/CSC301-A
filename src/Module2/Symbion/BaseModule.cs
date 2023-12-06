namespace Symbion {
	public class BaseModule : IModule {

		private static IShell _shell;

		public static IShell Shell {
			get {
				if (_shell == null)
					_shell = ServiceRepository.Get<IShell>();
				return _shell;
			}
		}

		public virtual void Exit() {
			//	blank implementation
		}

		public virtual void Init() {
			//	blank implementation
		}
	}
}
