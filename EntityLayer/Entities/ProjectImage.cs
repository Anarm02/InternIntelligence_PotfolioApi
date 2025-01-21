using EntityLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class ProjectImage:EntityBase
	{
		public string FilePath { get; set; } 
		public Guid ProjectId { get; set; }
		public Project Project { get; set; }
	}
}
