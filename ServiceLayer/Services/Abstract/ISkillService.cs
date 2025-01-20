using EntityLayer.DTOs.Skills;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Abstract
{
	public interface ISkillService
	{
		Task AddSkillAsync(SkillAddDto skillAddDto);
		Task RemoveSkillAsync(Guid id);
		Task<Skill> GetSkillAddAsync(Guid id);
		Task<IList<Skill>> GetSkillListAsync();
		Task<Skill> UpdateSkillAsync(SkillUpdateDto skill);
	}
}
