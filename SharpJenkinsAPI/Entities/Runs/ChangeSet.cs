using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Runs
{
	public class ChangeSet
	{
		public string _class { get; set; }
		private List<Item> _item;

		[JsonProperty("items")]
		public List<Item> Item
		{
			get
			{
				return this._item;
			}
			private set
			{
				this._item = value;
			}
		}


		public bool ItemSpecified
		{
			get
			{
				return (this.Item.Count != 0);
			}
		}
		[JsonProperty("kind")]
		public string Kind { get; set; }

		public ChangeSet()
		{
			this._item = new List<Item>();
		}
	}
}
