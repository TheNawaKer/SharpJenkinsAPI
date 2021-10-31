using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jobs
{
	public partial class WorkflowJob : Job
	{

		[JsonProperty("concurrentBuild")]
		public bool ConcurrentBuild { get; set; }

		[JsonProperty("resumeBlocked")]
		public bool ResumeBlocked { get; set; }
	}
}
