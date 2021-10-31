using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs.Fingerprints
{
	public partial class FingerprintRangeSet
	{


		private List<FingerprintRange> _ranges;

		[JsonProperty("ranges")]
		public List<FingerprintRange> Ranges
		{
			get
			{
				return this._ranges;
			}
			private set
			{
				this._ranges = value;
			}
		}


		public bool RangeSpecified
		{
			get
			{
				return (this.Ranges.Count != 0);
			}
		}

		public FingerprintRangeSet()
		{
			this._ranges = new List<FingerprintRange>();
		}


		public string _class { get; set; }
	}
}
