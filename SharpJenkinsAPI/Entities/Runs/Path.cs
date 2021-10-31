using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs
{
	public class Path
	{
		[JsonProperty("editType")]
		public string EditType { get; set; }
		[JsonProperty("file")]
		public string File { get; set; }
	}
}
