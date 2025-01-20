using EntityLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class Skill:EntityBase
	{
		public string Name { get; set; }
		public string ProfiencyLevel { get; set; }
	}
}
