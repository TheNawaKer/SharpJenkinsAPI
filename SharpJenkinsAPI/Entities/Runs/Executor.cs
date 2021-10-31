using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs
{
	public partial class Executor
	{

		[JsonProperty("currentExecutable")]
		public object CurrentExecutable { get; set; }

		[JsonProperty("idle")]
		public bool Idle { get; set; }

		[JsonProperty("likelyStuck")]
		public bool LikelyStuck { get; set; }

		[JsonProperty("number")]
		public int Number { get; set; }

		[JsonProperty("progress")]
		public int Progress { get; set; }

		public string _class { get; set; }
	}
}
