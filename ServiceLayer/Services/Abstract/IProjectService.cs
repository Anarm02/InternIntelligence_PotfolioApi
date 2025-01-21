using EntityLayer.DTOs.Projects;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Abstract
{
	public interface IProjectService
	{
		Task<IList<ProjectDto>> GetAllProjectsAsync();
		Task<Project> GetProjectAsync(Guid id);
		Task DeleteProjectAsync(Guid id);
		Task<Project> UpdateProjectAsync(ProjectUpdateDto dto);
		Task AddProjectAsync(ProjectAddDto dto);
	}
}
