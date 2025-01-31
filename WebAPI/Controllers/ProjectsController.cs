using DataAccessLayer.UnitOfWorks;
using EntityLayer.DTOs.Projects;
using EntityLayer.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;
using ServiceLayer.Services.Concrete;


namespace WebAPI.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class ProjectsController : ControllerBase
	{
		private readonly IProjectService projectService;
		private readonly IWebHostEnvironment _environment;
		private readonly IImageService _imageService;



		public ProjectsController(IProjectService projectService, IWebHostEnvironment environment, IImageService imageService)
		{
			this.projectService = projectService;
			_environment = environment;
			_imageService = imageService;
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
		[AllowAnonymous]
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
		[HttpPost("{projectId}/[action]")]
		public async Task<IActionResult> UploadFile(Guid projectId, IFormFile formFile)
		{
			if (formFile == null || formFile.Length == 0)
				return BadRequest("File is empty");

			
			string relativeUploadPath = Path.Combine("Uploads", "ProjectImages");
			string uploadPath = Path.Combine(_environment.WebRootPath, relativeUploadPath);

			if (!Directory.Exists(uploadPath))
			{
				Directory.CreateDirectory(uploadPath);
			}

			bool isUploaded = await _imageService.UploadProjectImage(projectId, formFile, uploadPath, relativeUploadPath);

			if (!isUploaded)
				return BadRequest("Something went wrong.");

			return Ok("Image successfully uploaded.");
		}


	}
}
