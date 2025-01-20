using DataAccessLayer.DataContext;
using EntityLayer.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class Repository<T> : IRepository<T> where T : class, IEntityBase
	{
		private readonly AppDbContext _appDbContext;

		public Repository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		private DbSet<T> Table { get=>_appDbContext.Set<T>();  }

		public async Task AddAsync(T entity)
		{
			await Table.AddAsync(entity);
		}

		public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
		{
			return await Table.AnyAsync(predicate);
		}

		public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> query=Table;
			if(predicate!=null)
				query = query.Where(predicate);
			if (includeProperties.Any())
				foreach (var property in includeProperties)
					query = query.Include(property);
			return await query.ToListAsync();
		}

		public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> query=Table;
			query = query.Where(predicate);
			if (includeProperties.Any())
				foreach (var property in includeProperties)
					query = query.Include(property);
			return await query.SingleAsync();
		}

		public async Task<T> GetByGuidAsync(Guid id)
		{
			return await Table.FindAsync(id);
		}

		public async Task HardDeleteAsync(T entity)
		{
		await	Task.Run(()=>Table.Remove(entity));
		}

		

		public async Task<T> UpdateAsync(T entity)
		{
			await Task.Run(() => Table.Update(entity));
			return entity;
		}
	}
}
