using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs.AchievementDto
{
	public class AchievementAddDto
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime DateAchieved { get; set; }
	}
}
