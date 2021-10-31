using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs
{
	public class Author
	{
		[JsonProperty("absoluteUrl")]
		public string AbsoluteUrl { get; set; }
		[JsonProperty("fullName")]
		public string FullName { get; set; }
	}
}
