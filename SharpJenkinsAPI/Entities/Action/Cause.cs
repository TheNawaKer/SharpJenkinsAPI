using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Build
{
	public class Cause
	{
		public string _class { get; set; }
		[JsonProperty("shortDescription")]
		public string ShortDescription { get; set; }
		[JsonProperty("userId")]
		public string UserId { get; set; }
		[JsonProperty("userName")]
		public string UserName { get; set; }
	}
}
