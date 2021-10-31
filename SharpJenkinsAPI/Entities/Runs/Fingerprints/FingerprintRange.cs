using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs.Fingerprints
{
	public partial class FingerprintRange
	{

		[JsonProperty("end")]
		public int End { get; set; }

		[JsonProperty("start")]
		public int Start { get; set; }


		public string _class { get; set; }
	}
}
