﻿using DataAccessLayer.UnitOfWorks;
using EntityLayer.DTOs.Projects;
using EntityLayer.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;


namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProjectsController : ControllerBase
	{
		private readonly IProjectService projectService;

		public ProjectsController(IProjectService projectService)
		{
			this.projectService = projectService;
		}
		[HttpPost("[action]")]
		public async Task<IActionResult> AddProject(ProjectAddDto projectAddDto)
		{
			try
			{
				await projectService.AddProjectAsync(projectAddDto);
				return StatusCode(StatusCodes.Status201Created);
			}
			catch (ValidationException ex)
			{
				ModelState.AddModelError("ValidationErrors", ex.Message);
				return BadRequest(ModelState);
			}
		}
		[HttpDelete("[action]/{id}")]
		public async Task<IActionResult> DeleteProject(Guid id)
		{
			if (id != null)
			{
				await projectService.DeleteProjectAsync(id);
				return Ok("Deleted successfully");
			}
			return BadRequest("Invalid id");
		}
		[HttpGet]
		public async Task<IActionResult> GetAllProjects()
		{
			var projects = await projectService.GetAllProjectsAsync();
			return Ok(projects);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetProject(Guid id)
		{
			var project=await projectService.GetProjectAsync(id);
			if (project == null)
			{
				return BadRequest("Can't find project");
			}
			return Ok(project);
		}
		[HttpPut]
		public async Task<IActionResult> UpdateProject(ProjectUpdateDto projectUpdateDto)
		{
			var project=await projectService.UpdateProjectAsync(projectUpdateDto);
			return Ok(project);
		}

	}
}
