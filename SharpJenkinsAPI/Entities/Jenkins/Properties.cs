using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpJenkinsAPI.Entities.Jenkins
{
	public partial class Properties : Label
	{


		private List<Property> _propertiesList;

		[JsonProperty("propertiesList")]
		public List<Property> PropertiesList
		{
			get
			{
				return this._propertiesList;
			}
			private set
			{
				this._propertiesList = value;
			}
		}


		public bool PropertiesListSpecified
		{
			get
			{
				return (this.PropertiesList.Count != 0);
			}
		}

		public Properties()
		{
			this._propertiesList = new List<Property>();
		}
	}
}
