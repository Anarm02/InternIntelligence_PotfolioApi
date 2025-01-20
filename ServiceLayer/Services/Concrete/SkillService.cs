using AutoMapper;
using DataAccessLayer.UnitOfWorks;
using EntityLayer.DTOs.Skills;
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
	public class SkillService : ISkillService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly IValidator<Skill> _validator;

		public SkillService(IUnitOfWork unitOfWork, IMapper mapper, IValidator<Skill> validator)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_validator = validator;
		}

		public async Task AddSkillAsync(SkillAddDto skillAddDto)
		{
			var map = _mapper.Map<Skill>(skillAddDto);
			var res = _validator.Validate(map);
			if (!res.IsValid)
			{
				var errors = res.Errors.Select(x => x.ErrorMessage);
				throw new ValidationException(string.Join(", ", errors));
			}
			await _unitOfWork.GetRepository<Skill>().AddAsync(map);
			await _unitOfWork.SaveAsync();
		}

		public async Task<Skill> GetSkillAddAsync(Guid id)
		{
			var skill=await _unitOfWork.GetRepository<Skill>().GetAsync(x=>!x.IsDeleted && x.Id == id);
			return skill;
		}

		public async Task<IList<Skill>> GetSkillListAsync()
		{
			return await _unitOfWork.GetRepository<Skill>().GetAllAsync(x=>!x.IsDeleted);
		}

		public async Task RemoveSkillAsync(Guid id)
		{
			var skill=await _unitOfWork.GetRepository<Skill>().GetByGuidAsync(id);
			skill.IsDeleted = true;
			await _unitOfWork.SaveAsync();
		}

		public async Task<Skill> UpdateSkillAsync(SkillUpdateDto skill)
		{
			var skillToUpdate = await _unitOfWork.GetRepository<Skill>().GetByGuidAsync(skill.Id);
			skillToUpdate.ProfiencyLevel = skill.ProfiencyLevel;
			skillToUpdate.Name = skill.Name;
			await _unitOfWork.SaveAsync();
			return skillToUpdate;
		}
	}
}
