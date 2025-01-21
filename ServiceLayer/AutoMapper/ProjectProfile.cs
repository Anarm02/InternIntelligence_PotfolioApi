using AutoMapper;
using EntityLayer.DTOs.Projects;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.AutoMapper
{
	public class ProjectProfile:Profile
	{
		public ProjectProfile()
		{
			CreateMap<ProjectUpdateDto, Project>().ReverseMap();
			CreateMap<ProjectAddDto, Project>().ReverseMap();
			CreateMap<Project,ProjectDto>().ReverseMap();
		}
	}
}
