using EntityLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public interface IRepository<T> where T:class,IEntityBase
	{
		Task AddAsync(T entity);
		Task<T> UpdateAsync(T entity);
		Task HardDeleteAsync(T entity);
		Task<T> GetByGuidAsync(Guid id);
		Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null,params Expression<Func<T, object>>[] includeProperties);
		Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
		Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
	}
}
