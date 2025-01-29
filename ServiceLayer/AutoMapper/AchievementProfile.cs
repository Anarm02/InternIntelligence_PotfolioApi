using AutoMapper;
using EntityLayer.DTOs.AchievementDto;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.AutoMapper
{
	public class AchievementProfile:Profile
	{
		public AchievementProfile()
		{
			CreateMap<Achievement,AchievementAddDto>().ReverseMap();
			CreateMap<Achievement,AchievementUpdateDto>().ReverseMap();
		}
	}
}
