using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Queue
{
	public class Executable
	{
		public string _class { get; set; }
		[JsonProperty("number")]
		public int Number { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}
