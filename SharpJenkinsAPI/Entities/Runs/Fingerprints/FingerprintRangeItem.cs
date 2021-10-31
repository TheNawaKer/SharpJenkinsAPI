using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs.Fingerprints
{
	public partial class FingerprintRangeItem
	{

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("ranges")]
		public FingerprintRangeSet Ranges { get; set; }

		public string _class { get; set; }
	}
}
