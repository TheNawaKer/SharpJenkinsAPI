using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs.Fingerprints
{
	public partial class Fingerprint
	{

		[JsonProperty("fileName")]
		public string FileName { get; set; }

		[JsonProperty("hash")]
		public string Hash { get; set; }

		[JsonProperty("original")]
		public FingerprintBuildPtr Original { get; set; }

		[JsonProperty("timestamp")]
		public object Timestamp { get; set; }


		private List<FingerprintRangeItem> _usages;

		[JsonProperty("usages")]
		public List<FingerprintRangeItem> Usages
		{
			get
			{
				return this._usages;
			}
			private set
			{
				this._usages = value;
			}
		}


		public bool UsageSpecified
		{
			get
			{
				return (this.Usages.Count != 0);
			}
		}

		public Fingerprint()
		{
			this._usages = new List<FingerprintRangeItem>();
		}

		public string _class { get; set; }
	}
}
