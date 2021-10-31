using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SharpJenkinsAPI.Entities.Generic;
using SharpJenkinsAPI.Entities.Queue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jobs
{
	public partial class Job : AbstractItem
	{


		private List<Runs.Run> _allBuilds;

		[JsonProperty("allBuilds")]
		public List<Runs.Run> AllBuilds
		{
			get
			{
				return this._allBuilds;
			}
			private set
			{
				this._allBuilds = value;
			}
		}


		public bool AllBuildSpecified
		{
			get
			{
				return (this.AllBuilds.Count != 0);
			}
		}

		public Job()
		{
			this._allBuilds = new List<Runs.Run>();
			this._builds = new List<Runs.Run>();
			this._healthReport = new List<HealthReport>();
			this._property = new List<JobProperty>();
		}

		[JsonProperty("buildable")]
		public bool Buildable { get; set; }


		private List<Runs.Run> _builds;

		[JsonProperty("builds")]
		public List<Runs.Run> Builds
		{
			get
			{
				return this._builds;
			}
			private set
			{
				this._builds = value;
			}
		}


		public bool BuildSpecified
		{
			get
			{
				return (this.Builds.Count != 0);
			}
		}

		[JsonProperty("color")]
		[JsonConverter(typeof(StringEnumConverter))]
		public BallColor ColorValue { get; set; }


		public bool ColorValueSpecified { get; set; }

		[JsonConverter(typeof(StringEnumConverter))]
		public System.Nullable<BallColor> Color
		{
			get
			{
				if (this.ColorValueSpecified)
				{
					return this.ColorValue;
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.ColorValue = value.GetValueOrDefault();
				this.ColorValueSpecified = value.HasValue;
			}
		}

		[JsonProperty("firstBuild")]
		public Runs.Run FirstBuild { get; set; }


		private List<HealthReport> _healthReport;

		[JsonProperty("healthReport")]
		public List<HealthReport> HealthReport
		{
			get
			{
				return this._healthReport;
			}
			private set
			{
				this._healthReport = value;
			}
		}


		public bool HealthReportSpecified
		{
			get
			{
				return (this.HealthReport.Count != 0);
			}
		}

		[JsonProperty("inQueue")]
		public bool InQueue { get; set; }

		[JsonProperty("keepDependencies")]
		public bool KeepDependencies { get; set; }

		[JsonProperty("lastBuild")]
		public Runs.Run LastBuild { get; set; }

		[JsonProperty("lastCompletedBuild")]
		public Runs.Run LastCompletedBuild { get; set; }

		[JsonProperty("lastFailedBuild")]
		public Runs.Run LastFailedBuild { get; set; }

		[JsonProperty("lastStableBuild")]
		public Runs.Run LastStableBuild { get; set; }

		[JsonProperty("lastSuccessfulBuild")]
		public Runs.Run LastSuccessfulBuild { get; set; }

		[JsonProperty("lastUnstableBuild")]
		public Runs.Run LastUnstableBuild { get; set; }

		[JsonProperty("lastUnsuccessfulBuild")]
		public Runs.Run LastUnsuccessfulBuild { get; set; }

		[JsonProperty("nextBuildNumber")]
		public int NextBuildNumber { get; set; }


		private List<JobProperty> _property;

		[JsonProperty("property")]
		public List<JobProperty> Property
		{
			get
			{
				return this._property;
			}
			private set
			{
				this._property = value;
			}
		}


		public bool PropertySpecified
		{
			get
			{
				return (this.Property.Count != 0);
			}
		}

		[JsonProperty("queueItem")]
		public QueueItem QueueItem { get; set; }
	}

	public enum BallColor
	{

		[Description("red")]
		Red,

		[Description("red_anime")]
		Red_Anime,

		[Description("yellow")]
		Yellow,

		[Description("yellow_anime")]
		Yellow_Anime,

		[Description("blue")]
		Blue,

		[Description("blue_anime")]
		Blue_Anime,

		[Description("grey")]
		Grey,

		[Description("grey_anime")]
		Grey_Anime,

		[Description("disabled")]
		Disabled,

		[Description("disabled_anime")]
		Disabled_Anime,

		[Description("aborted")]
		Aborted,

		[Description("aborted_anime")]
		Aborted_Anime,

		[Description("notbuilt")]
		Notbuilt,

		[Description("notbuilt_anime")]
		Notbuilt_Anime,
	}
}
