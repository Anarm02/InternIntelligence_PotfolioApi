using AutoMapper;
using DataAccessLayer.UnitOfWorks;
using EntityLayer.DTOs.Projects;
using EntityLayer.Entities;
using FluentValidation;
using ServiceLayer.Extensions;
using ServiceLayer.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages;

namespace ServiceLayer.Services.Concrete
{
	public class ProjectService : IProjectService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;
		private readonly IValidator<Project> validator;
		public ProjectService(IUnitOfWork unitOfWork, IMapper mapper, IValidator<Project> validator)
		{
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
			this.validator = validator;
		}

		public async Task AddProjectAsync(ProjectAddDto dto)
		{
			var map = mapper.Map<Project>(dto);
			var res = await validator.ValidateAsync(map);
			if (!res.IsValid)
			{
				var errors = res.Errors.Select(e => e.ErrorMessage).ToList();
				throw new ValidationException(string.Join(", ", errors));
			}
			await unitOfWork.GetRepository<Project>().AddAsync(map);
			await unitOfWork.SaveAsync();
		}

		public async Task DeleteProjectAsync(Guid id)
		{
			var project = await unitOfWork.GetRepository<Project>().GetByGuidAsync(id);
			project.IsDeleted = true;
			await unitOfWork.SaveAsync();
		}

		public async Task<IList<ProjectDto>> GetAllProjectsAsync()
		{
			var projects= await unitOfWork.GetRepository<Project>().GetAllAsync(x => !x.IsDeleted,x=>x.ProjectImage);
			List<ProjectDto> projectDtos = new List<ProjectDto>();
			foreach (var project in projects)
			{
				if(project is not null)
				{
					projectDtos.Add(new()
					{
						Description = project.Description,
						Title = project.Title,
						Id=project.Id,
						ImagePath = project.ProjectImage?.FilePath ?? string.Empty,
						ProjectUrl = project.ProjectUrl
					});
				}
			}
			return projectDtos;
		}

		public async Task<Project> GetProjectAsync(Guid id)
		{
			return await unitOfWork.GetRepository<Project>().GetAsync(x => !x.IsDeleted && x.Id == id);
		}

		public async Task<Project> UpdateProjectAsync(ProjectUpdateDto dto)
		{
			var project = await unitOfWork.GetRepository<Project>().GetByGuidAsync(dto.Id);
			project.ProjectUrl = dto.ProjectUrl;
			project.Title = dto.Title;
			project.Description = dto.Description;
			await unitOfWork.SaveAsync();
			return project;
		}
	}
}
