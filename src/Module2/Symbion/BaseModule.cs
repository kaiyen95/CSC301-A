namespace Symbion {
	public class BaseModule : IModule {

		private static IShell _shell;

		public static IShell Shell {
			get {
				return _shell ?? (_shell = ServiceRepository.Get<IShell>());
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
