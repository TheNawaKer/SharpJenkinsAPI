using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jenkins
{
	public partial class OverallLoadStatistics : LoadStatistics
	{

		[JsonProperty("totalQueueLength")]
		public MultiStageTimeSeries TotalQueueLength { get; set; }
	}
}
