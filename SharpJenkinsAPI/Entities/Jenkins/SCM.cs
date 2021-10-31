using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jenkins
{
	public partial class SCM
	{

		[JsonProperty("browser")]
		public SCMRepositoryBrowser Browser { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }


		public string _class { get; set; }
	}
}
