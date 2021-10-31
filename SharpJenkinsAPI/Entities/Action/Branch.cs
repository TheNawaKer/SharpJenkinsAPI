using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Build
{
	public class Branch
	{
		public string SHA1 { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
