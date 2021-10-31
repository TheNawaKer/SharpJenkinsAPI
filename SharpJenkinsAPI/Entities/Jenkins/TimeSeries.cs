using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jenkins
{
	public partial class TimeSeries
	{


		private List<object> _history;

		[JsonProperty("history")]
		public List<object> History
		{
			get
			{
				return this._history;
			}
			private set
			{
				this._history = value;
			}
		}


		public bool HistorySpecified
		{
			get
			{
				return (this.History.Count != 0);
			}
		}

		public TimeSeries()
		{
			this._history = new List<object>();
		}

		[JsonProperty("latest")]
		public object Latest { get; set; }


		public string _class { get; set; }
	}
}
