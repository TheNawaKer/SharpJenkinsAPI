using Newtonsoft.Json;
using SharpJenkinsAPI.Entities.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Queue
{
	public class QueueItem : Actionable
	{

		[JsonProperty("blocked")]
		public bool Blocked { get; set; }

		[JsonProperty("buildable")]
		public bool Buildable { get; set; }

		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("inQueueSince")]
		public long InQueueSince { get; set; }

		[JsonProperty("params")]
		public string Params { get; set; }

		[JsonProperty("stuck")]
		public bool Stuck { get; set; }

		[JsonProperty("task")]
		public Task Task { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("why")]
		public string Why { get; set; }

		[JsonProperty("executable")]
		public Executable Executable { get; set; }
	}
}
