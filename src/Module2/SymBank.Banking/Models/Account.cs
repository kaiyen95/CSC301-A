using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymBank.Banking.Models {
	public partial class Account {
		public override string ToString() {
			return $"{Code},{Name},{Balance}";
		}
	}
}
