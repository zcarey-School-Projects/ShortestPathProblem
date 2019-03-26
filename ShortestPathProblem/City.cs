using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathProblem {
	public class City {

		private string name = "N/A";
		public string Name {
			get => name;
			set {
				if((value != null) && (value.Length > 0)) {
					name = value;
				}
			}
		}

	}
}
