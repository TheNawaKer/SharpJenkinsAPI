using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jenkins
{
	public partial class Node
	{


		private List<Properties> _assignedLabels;

		[JsonProperty("assignedLabels")]
		public List<Properties> AssignedLabels
		{
			get
			{
				return this._assignedLabels;
			}
			private set
			{
				this._assignedLabels = value;
			}
		}


		public bool AssignedLabelSpecified
		{
			get
			{
				return (this.AssignedLabels.Count != 0);
			}
		}

		public Node()
		{
			this._assignedLabels = new List<Properties>();
		}


		[JsonProperty("mode")]
		public Node_Mode ModeValue { get; set; }



		public bool ModeValueSpecified { get; set; }


		public System.Nullable<Node_Mode> Mode
		{
			get
			{
				if (this.ModeValueSpecified)
				{
					return this.ModeValue;
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.ModeValue = value.GetValueOrDefault();
				this.ModeValueSpecified = value.HasValue;
			}
		}

		[JsonProperty("nodeDescription")]
		public string NodeDescription { get; set; }

		[JsonProperty("nodeName")]
		public string NodeName { get; set; }

		[JsonProperty("numExecutors")]
		public int NumExecutors { get; set; }


		public string _class { get; set; }
	}

	public enum Node_Mode
	{

		NORMAL,
		EXCLUSIVE,
	}
}
