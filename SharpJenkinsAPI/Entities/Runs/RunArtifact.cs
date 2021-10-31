using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs
{
	public partial class RunArtifact
	{

		[JsonProperty("displayPath")]
		public string DisplayPath { get; set; }

		[JsonProperty("fileName")]
		public string FileName { get; set; }

		[JsonProperty("relativePath")]
		public string RelativePath { get; set; }

		public string _class { get; set; }
	}
}
