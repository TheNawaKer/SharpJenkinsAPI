using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs.Fingerprints
{
	public partial class FingerprintBuildPtr
	{

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("number")]
		public int Number { get; set; }

		public string _class { get; set; }
	}
}
