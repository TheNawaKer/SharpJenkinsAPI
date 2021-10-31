using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Generic
{
	public abstract class AbstractItem : Actionable
	{

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		[JsonProperty("displayNameOrNull")]
		public string DisplayNameOrNull { get; set; }

		[JsonProperty("fullDisplayName")]
		public string FullDisplayName { get; set; }

		[JsonProperty("fullName")]
		public string FullName { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}
}
