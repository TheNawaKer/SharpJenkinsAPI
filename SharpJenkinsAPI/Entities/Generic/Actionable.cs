using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Generic
{
	public abstract class Actionable
	{


		private List<Action> _actions;

		[JsonProperty("actions")]
		public List<Action> Actions
		{
			get
			{
				return this._actions;
			}
			private set
			{
				this._actions = value;
			}
		}


		public bool ActionSpecified
		{
			get
			{
				return (this.Actions.Count != 0);
			}
		}

		public Actionable()
		{
			this._actions = new List<Action>();
		}

		public string _class { get; set; }
	}
}
