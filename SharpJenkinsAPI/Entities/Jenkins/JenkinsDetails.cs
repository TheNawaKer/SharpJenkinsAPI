using Newtonsoft.Json;
using SharpJenkinsAPI.Entities.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jenkins
{
	public partial class JenkinsDetails : Node
	{

		[JsonProperty("description")]
		public string Description { get; set; }


		private List<Job> _jobs;

		[JsonProperty("jobs")]
		public List<Job> Jobs
		{
			get
			{
				return this._jobs;
			}
			private set
			{
				this._jobs = value;
			}
		}


		public bool JobSpecified
		{
			get
			{
				return (this.Jobs.Count != 0);
			}
		}

		public JenkinsDetails()
		{
			this._jobs = new List<Job>();
			this._views = new List<View>();
		}

		[JsonProperty("overallLoad")]
		public OverallLoadStatistics OverallLoad { get; set; }

		[JsonProperty("primaryView")]
		public View PrimaryView { get; set; }

		[JsonProperty("quietDownReason")]
		public string QuietDownReason { get; set; }

		[JsonProperty("quietingDown")]
		public bool QuietingDown { get; set; }

		[JsonProperty("slaveAgentPort")]
		public int SlaveAgentPort { get; set; }

		[JsonProperty("unlabeledLoad")]
		public LoadStatistics UnlabeledLoad { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("useCrumbs")]
		public bool UseCrumbs { get; set; }

		[JsonProperty("useSecurity")]
		public bool UseSecurity { get; set; }


		private List<View> _views;

		[JsonProperty("views")]
		public List<View> Views
		{
			get
			{
				return this._views;
			}
			private set
			{
				this._views = value;
			}
		}


		public bool ViewSpecified
		{
			get
			{
				return (this.Views.Count != 0);
			}
		}
	}
}
