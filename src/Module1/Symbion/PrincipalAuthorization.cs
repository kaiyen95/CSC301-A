using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Symbion {
	public class PrincipalAuthorization : IAuthorization {

		//	private string _userName;
		//	public string UserName => _userName;
		//	public string UserName { get => _userName; }
		//	public string UserName { get { return _userName; } }

		//	private WindowsPrincipal _principal; // only for Windows
		private IPrincipal _principal;

		public string UserName {
			get {
				return _principal.Identity.Name;
			}
		}

		public bool IsInAllRoles(IEnumerable<string> roleNames) {
			foreach (string roleName in roleNames)
				if (!_principal.IsInRole(roleName))
					return false;
			return true;
		}

		public bool IsInAnyRoles(IEnumerable<string> roleNames) {
			foreach (string roleName in roleNames)
				if (_principal.IsInRole(roleName))
					return true;
			return false;
		}

		public bool IsInRole(string roleName) {
			return _principal.IsInRole(roleName);
		}

		public PrincipalAuthorization() {
			//	WindowsIdentity identity = WindowsIdentity.GetCurrent();
			//	_principal = new WindowsPrincipal(identity);
			_principal = Thread.CurrentPrincipal;
		}
	}
}
