using Newtonsoft.Json;
using SharpJenkinsAPI.Entities.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jenkins
{
	public partial class Label : Actionable
	{

		[JsonProperty("busyExecutors")]
		public int BusyExecutors { get; set; }


		private List<Actionable> _clouds;

		[JsonProperty("clouds")]
		public List<Actionable> Clouds
		{
			get
			{
				return this._clouds;
			}
			private set
			{
				this._clouds = value;
			}
		}


		public bool CloudSpecified
		{
			get
			{
				return (this.Clouds.Count != 0);
			}
		}

		public Label()
		{
			this._clouds = new List<Actionable>();
			this._nodes = new List<Node>();
			this._tiedJobs = new List<AbstractProject>();
		}

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("idleExecutors")]
		public int IdleExecutors { get; set; }

		[JsonProperty("loadStatistics")]
		public LoadStatistics LoadStatistics { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }


		private List<Node> _nodes;

		[JsonProperty("nodes")]
		public List<Node> Nodes
		{
			get
			{
				return this._nodes;
			}
			private set
			{
				this._nodes = value;
			}
		}


		public bool NodeSpecified
		{
			get
			{
				return (this.Nodes.Count != 0);
			}
		}

		[JsonProperty("offline")]
		public bool Offline { get; set; }


		private List<AbstractProject> _tiedJobs;

		[JsonProperty("tiedJobs")]
		public List<AbstractProject> TiedJobs
		{
			get
			{
				return this._tiedJobs;
			}
			private set
			{
				this._tiedJobs = value;
			}
		}


		public bool TiedJobSpecified
		{
			get
			{
				return (this.TiedJobs.Count != 0);
			}
		}

		[JsonProperty("totalExecutors")]
		public int TotalExecutors { get; set; }
	}
}
