using EntityLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class Achievement:EntityBase
	{

		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime DateAchieved { get; set; }
	}
}
