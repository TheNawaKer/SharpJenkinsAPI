using Newtonsoft.Json;
using SharpJenkinsAPI.Entities.Build;
using SharpJenkinsAPI.Entities.Generic;
using SharpJenkinsAPI.Entities.Runs.Fingerprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs
{
	public partial class Run : Actionable
	{


		private List<RunArtifact> _artifacts;

		[JsonProperty("artifacts")]
		public List<RunArtifact> Artifacts
		{
			get
			{
				return this._artifacts;
			}
			private set
			{
				this._artifacts = value;
			}
		}


		public bool ArtifactSpecified
		{
			get
			{
				return (this.Artifacts.Count != 0);
			}
		}

		public Run()
		{
			this._artifacts = new List<RunArtifact>();
			this._fingerprints = new List<Fingerprint>();
			this._culprits = new List<Culprit>();
		}

		[JsonProperty("building")]
		public bool Building { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		[JsonProperty("duration")]
		public long Duration { get; set; }

		[JsonProperty("estimatedDuration")]
		public long EstimatedDuration { get; set; }

		[JsonProperty("executor")]
		public Executor Executor { get; set; }


		private List<Fingerprint> _fingerprints;

		[JsonProperty("fingerprints")]
		public List<Fingerprint> Fingerprints
		{
			get
			{
				return this._fingerprints;
			}
			private set
			{
				this._fingerprints = value;
			}
		}


		public bool FingerprintSpecified
		{
			get
			{
				return (this.Fingerprints.Count != 0);
			}
		}

		[JsonProperty("fullDisplayName")]
		public string FullDisplayName { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("keepLog")]
		public bool KeepLog { get; set; }

		[JsonProperty("number")]
		public int Number { get; set; }

		[JsonProperty("queueId")]
		public long QueueId { get; set; }

		[JsonProperty("result")]
		public string Result { get; set; }

		[JsonProperty("timestamp")]
		public long TimestampValue { get; set; }

		public bool TimestampValueSpecified { get; set; }


		public System.Nullable<long> Timestamp
		{
			get
			{
				if (this.TimestampValueSpecified)
				{
					return this.TimestampValue;
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.TimestampValue = value.GetValueOrDefault();
				this.TimestampValueSpecified = value.HasValue;
			}
		}

		[JsonProperty("url")]
		public string Url { get; set; }

		private List<Culprit> _culprits;

		[JsonProperty("culprits")]
		public List<Culprit> Culprits
		{
			get
			{
				return this._culprits;
			}
			private set
			{
				this._culprits = value;
			}
		}


		public bool CulpritSpecified
		{
			get
			{
				return (this.Culprits.Count != 0);
			}
		}

		private List<ChangeSet> _changesets;

		[JsonProperty("changesets")]
		public List<ChangeSet> ChangeSets
		{
			get
			{
				return this._changesets;
			}
			private set
			{
				this._changesets = value;
			}
		}


		public bool ChangeSetSpecified
		{
			get
			{
				return (this.ChangeSets.Count != 0);
			}
		}
	}
}
