using AutoMapper;
using DataAccessLayer.UnitOfWorks;
using EntityLayer.DTOs.AchievementDto;
using EntityLayer.Entities;
using FluentValidation;
using ServiceLayer.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Concrete
{
	public class AchievementService : IAchievementService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly IValidator<Achievement> _validator;

		public AchievementService(IUnitOfWork unitOfWork, IMapper mapper, IValidator<Achievement> validator)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_validator = validator;
		}

		public async Task AddAsync(AchievementAddDto achievementAddDto)
		{
			var map=_mapper.Map<Achievement>(achievementAddDto);
			var result=await _validator.ValidateAsync(map);
			if (!result.IsValid)
			{
				var errors=result.Errors.Select(x=>x.ErrorMessage);
				throw new ValidationException(string.Join(", ", errors));
			}
			await _unitOfWork.GetRepository<Achievement>().AddAsync(map);
			await _unitOfWork.SaveAsync();
		}

		public async Task DeleteAsync(Guid id)
		{
			var achievement=await _unitOfWork.GetRepository<Achievement>().GetByGuidAsync(id);
			achievement.IsDeleted = true;
			await _unitOfWork.GetRepository<Achievement>().UpdateAsync(achievement);
			await _unitOfWork.SaveAsync();
		}

		public async Task<IList<Achievement>> GetAllAsync()
		{
			var achievements = await _unitOfWork.GetRepository<Achievement>().GetAllAsync(x => !x.IsDeleted);
			return achievements;
		}

		public async Task<Achievement> GetAsync(Guid id)
		{
			var achievement = await _unitOfWork.GetRepository<Achievement>().GetAsync(x => !x.IsDeleted && x.Id==id);
			return achievement;
		}

		public async Task<Achievement> UpdateAsync(AchievementUpdateDto achievementUpdateDto)
		{
			var achievement = await _unitOfWork.GetRepository<Achievement>().GetByGuidAsync(achievementUpdateDto.Id);
			achievement.Title=achievementUpdateDto.Title;
			achievement.Description=achievementUpdateDto.Description;
			achievement.DateAchieved=achievementUpdateDto.DateAchieved;
			await _unitOfWork.GetRepository<Achievement>().UpdateAsync(achievement);
			await _unitOfWork.SaveAsync();
			return achievement;
		}
	}
}
