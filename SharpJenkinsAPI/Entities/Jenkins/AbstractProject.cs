using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpJenkinsAPI.Entities.Jobs;

namespace SharpJenkinsAPI.Entities.Jenkins
{
	public partial class AbstractProject : Job
	{

		[JsonProperty("concurrentBuild")]
		public bool ConcurrentBuild { get; set; }

		[JsonProperty("disabled")]
		public bool Disabled { get; set; }


		private List<AbstractProject> _downstreamProjects;

		[JsonProperty("downstreamProjects")]
		public List<AbstractProject> DownstreamProjects
		{
			get
			{
				return this._downstreamProjects;
			}
			private set
			{
				this._downstreamProjects = value;
			}
		}


		public bool DownstreamProjectSpecified
		{
			get
			{
				return (this.DownstreamProjects.Count != 0);
			}
		}

		public AbstractProject()
		{
			this._downstreamProjects = new List<AbstractProject>();
			this._upstreamProjects = new List<AbstractProject>();
		}

		[JsonProperty("labelExpression")]
		public string LabelExpression { get; set; }

		[JsonProperty("scm")]
		public SCM Scm { get; set; }


		private List<AbstractProject> _upstreamProjects;

		[JsonProperty("upstreamProjects")]
		public List<AbstractProject> UpstreamProjects
		{
			get
			{
				return this._upstreamProjects;
			}
			private set
			{
				this._upstreamProjects = value;
			}
		}


		public bool UpstreamProjectSpecified
		{
			get
			{
				return (this.UpstreamProjects.Count != 0);
			}
		}
	}
}
