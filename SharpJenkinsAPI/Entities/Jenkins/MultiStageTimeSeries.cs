using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jenkins
{
	public partial class MultiStageTimeSeries
	{

		[JsonProperty("hour")]
		public TimeSeries Hour { get; set; }

		[JsonProperty("min")]
		public TimeSeries Min { get; set; }

		[JsonProperty("sec10")]
		public TimeSeries Sec10 { get; set; }


		public string _class { get; set; }
	}
}
