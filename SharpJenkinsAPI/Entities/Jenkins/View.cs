using Newtonsoft.Json;
using SharpJenkinsAPI.Entities.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jenkins
{
	public partial class View
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

		public View()
		{
			this._jobs = new List<Job>();
			this._property = new List<object>();
		}

		[JsonProperty("name")]
		public string Name { get; set; }


		private List<object> _property;

		[JsonProperty("property")]
		public List<object> Property
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

		[JsonProperty("url")]
		public string Url { get; set; }


		public string _class { get; set; }
	}
}
