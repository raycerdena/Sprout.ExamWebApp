using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.DataAccess.Interfaces
{
	public interface IGenericRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(object id);
		Task<T> InsertAsync(T obj);
		Task UpdateAsync(T obj);
		Task DeleteAsync(object id);
		Task SaveAsync();
	}
}
