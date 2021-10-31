using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs
{
	public class Item
	{
		public string _class { get; set; }
		[JsonProperty("affectedPaths")]
		public List<string> AffectedPaths { get; set; }
		[JsonProperty("commitId")]
		public string CommitId { get; set; }
		[JsonProperty("timestamp")]
		public long Timestamp { get; set; }
		[JsonProperty("author")]
		public Author Author { get; set; }
		[JsonProperty("authorEmail")]
		public string AuthorEmail { get; set; }
		[JsonProperty("comment")]
		public string Comment { get; set; }
		[JsonProperty("date")]
		public string Date { get; set; }
		[JsonProperty("id")]
		public string Id { get; set; }
		[JsonProperty("msg")]
		public string Msg { get; set; }

		private List<Path> _paths;

		[JsonProperty("paths")]
		public List<Path> Paths
		{
			get
			{
				return this._paths;
			}
			private set
			{
				this._paths = value;
			}
		}


		public bool PathSpecified
		{
			get
			{
				return (this.Paths.Count != 0);
			}
		}

		public Item()
		{
			this._paths = new List<Path>();
		}
	}
}
