using EntityLayer.DTOs.ContactMessage;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactMessageController : ControllerBase
	{
		private readonly IContactMessageService _contactMessageService;

		public ContactMessageController(IContactMessageService contactMessageService)
		{
			_contactMessageService = contactMessageService;
		}
		[HttpPost]
		public async Task<IActionResult> AddMessage(ContactMessageAddDto contactMessageAddDto)
		{
			try
			{
				await _contactMessageService.CreateAsync(contactMessageAddDto);
				return StatusCode(statusCode: 201);
			}
			catch (ValidationException ex)
			{

				ModelState.AddModelError("Validation Errors", ex.Message);
				return BadRequest(ModelState);

			}
		}
		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetAll()
		{
			var messages=await _contactMessageService.GetAllAsync();
			return Ok(messages);
		}
	}
}
