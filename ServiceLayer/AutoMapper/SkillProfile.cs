using AutoMapper;
using EntityLayer.DTOs.Skills;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.AutoMapper
{
	public class SkillProfile:Profile
	{
		public SkillProfile()
		{
			CreateMap<SkillAddDto,Skill>().ReverseMap();
			CreateMap<SkillUpdateDto,Skill>().ReverseMap();
		}
	}
}
