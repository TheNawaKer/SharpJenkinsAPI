using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jobs
{
	public partial class HealthReport
	{

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("iconClassName")]
		public string IconClassName { get; set; }

		[JsonProperty("iconUrl")]
		public string IconUrl { get; set; }

		[JsonProperty("score")]
		public int Score { get; set; }


		public string _class { get; set; }
	}
}
