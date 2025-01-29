using EntityLayer.DTOs.AchievementDto;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Abstract
{
	public interface IAchievementService
	{
		Task AddAsync(AchievementAddDto achievementAddDto);
		Task<Achievement> UpdateAsync(AchievementUpdateDto achievementUpdateDto);
		Task DeleteAsync(Guid id);
		Task<Achievement> GetAsync(Guid id);
		Task<IList<Achievement>> GetAllAsync();
	}
}
