using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jenkins
{
	public partial class LoadStatistics
	{

		[JsonProperty("availableExecutors")]
		public MultiStageTimeSeries AvailableExecutors { get; set; }

		[JsonProperty("busyExecutors")]
		public MultiStageTimeSeries BusyExecutors { get; set; }

		[JsonProperty("connectingExecutors")]
		public MultiStageTimeSeries ConnectingExecutors { get; set; }

		[JsonProperty("definedExecutors")]
		public MultiStageTimeSeries DefinedExecutors { get; set; }

		[JsonProperty("idleExecutors")]
		public MultiStageTimeSeries IdleExecutors { get; set; }

		[JsonProperty("onlineExecutors")]
		public MultiStageTimeSeries OnlineExecutors { get; set; }

		[JsonProperty("queueLength")]
		public MultiStageTimeSeries QueueLength { get; set; }

		[JsonProperty("totalExecutors")]
		public MultiStageTimeSeries TotalExecutors { get; set; }


		public string _class { get; set; }
	}
}
