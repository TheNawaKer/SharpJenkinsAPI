using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Build
{
	public class Action
	{
		public string _class { get; set; }
		private List<Cause> _causes;

		[JsonProperty("causes")]
		public List<Cause> Causes
		{
			get
			{
				return this._causes;
			}
			private set
			{
				this._causes = value;
			}
		}


		public bool CauseSpecified
		{
			get
			{
				return (this.Causes.Count != 0);
			}
		}
		[JsonProperty("lastBuiltRevision")]
		public BuiltRevision LastBuiltRevision { get; set; }
		[JsonProperty("remoteUrls")]
		public List<string> RemoteUrls { get; set; }
		[JsonProperty("scmName")]
		public string ScmName { get; set; }

		public Action()
		{
			this._causes = new List<Cause>();
		}
	}
}
