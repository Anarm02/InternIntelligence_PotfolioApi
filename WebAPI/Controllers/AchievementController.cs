using EntityLayer.DTOs.AchievementDto;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AchievementController : ControllerBase
	{
		private readonly IAchievementService _achievementService;

		public AchievementController(IAchievementService achievementService)
		{
			_achievementService = achievementService;
		}
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var achievements = await _achievementService.GetAllAsync();
			return Ok(achievements);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(Guid id)
		{
			var achievement=await _achievementService.GetAsync(id);
			return Ok(achievement);
		}
		[HttpPost]
		public async Task<IActionResult> Add(AchievementAddDto achievementAddDto)
		{
			try
			{
				await _achievementService.AddAsync(achievementAddDto);
				return StatusCode(StatusCodes.Status201Created);
			}
			catch (ValidationException validationException) {
				ModelState.AddModelError("ValidationErrors", validationException.Message);
				return BadRequest(ModelState);
			}
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
		     await _achievementService.DeleteAsync(id);
			return Ok("Achievement deleted succesfully");
		}
		[HttpPut]
		public async Task<IActionResult> Update(AchievementUpdateDto achievementUpdateDto)
		{
			var achievement=await _achievementService.UpdateAsync(achievementUpdateDto);
			return Ok(achievement);
		}
	}
}
