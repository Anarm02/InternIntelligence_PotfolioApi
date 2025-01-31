using EntityLayer.DTOs.Skills;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class SkillController : ControllerBase
	{
		private readonly ISkillService skillService;

		public SkillController(ISkillService skillService)
		{
			this.skillService = skillService;
		}
		[HttpGet]
		[AllowAnonymous]
		public async Task<IActionResult> GetAllSkills()
		{
			var skills = await skillService.GetSkillListAsync();
			return Ok(skills);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetSkill(Guid id)
		{
			var skill = await skillService.GetSkillAddAsync(id);
			return Ok(skill);
		}
		[HttpPost]
		public async Task<IActionResult> AddSkill(SkillAddDto skillAddDto)
		{
			try
			{
				await skillService.AddSkillAsync(skillAddDto);
				return StatusCode(StatusCodes.Status201Created);
			}
			catch (ValidationException ex)
			{
				ModelState.AddModelError("ValidationErrors", ex.Message);
				return BadRequest(ModelState);
			}
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> RemoveSkill(Guid id)
		{
			await skillService.RemoveSkillAsync(id);
			return Ok("Deleted successfully");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateSkill(SkillUpdateDto skillUpdateDto)
		{
			var skill=await skillService.UpdateSkillAsync(skillUpdateDto);
			return Ok(skill);
		}
	}
}
