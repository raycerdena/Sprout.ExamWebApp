using Microsoft.EntityFrameworkCore;
using Sprout.Exam.DataAccess.Interfaces;
using Sprout.Exam.DataAccess.Entities;
using Sprout.Exam.DataAccess.SproutDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sprout.Exam.DataAccess.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{

		private readonly DbContext _dbContext;
		
		public GenericRepository(DbContext dBContext)
		{
			_dbContext = dBContext;
			
		}
		public async Task DeleteAsync(object id)
		{
			//_dbContext.Entry(table).State = EntityState.Modified;
			T existing = await _dbContext.Set<T>().FindAsync(id);
			if (existing != null) { 
				
			}
		 	//table.Remove(existing);
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbContext.Set<T>().ToListAsync();

		}


		public async Task<T> GetByIdAsync(object id)
		{
			return await _dbContext.Set<T>().FindAsync(id);
		}

		public async Task<T> InsertAsync(T obj)
		{
            await _dbContext.Set<T>().AddAsync(obj);
            await _dbContext.SaveChangesAsync(CancellationToken.None);

			return obj;
        }

        public async Task SaveAsync()
		{
			await _dbContext.SaveChangesAsync();
		}

		public async Task UpdateAsync(T obj)
		{
            _dbContext.Set<T>().Attach(obj);
			_dbContext.Entry(obj).State = EntityState.Modified;
			await _dbContext.SaveChangesAsync(CancellationToken.None);
		}
	}
}


