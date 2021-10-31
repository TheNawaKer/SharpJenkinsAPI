using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Build
{
	public class BuiltRevision
	{
		public string SHA1 { get; set; }

		private List<Branch> _branch;

		[JsonProperty("branch")]
		public List<Branch> Branch
		{
			get
			{
				return this._branch;
			}
			private set
			{
				this._branch = value;
			}
		}


		public bool BranchSpecified
		{
			get
			{
				return (this.Branch.Count != 0);
			}
		}
		public BuiltRevision()
		{
			this._branch = new List<Branch>();
		}
	}
}
