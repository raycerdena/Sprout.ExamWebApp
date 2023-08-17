using Sprout.Exam.DataAccess;
using Sprout.Exam.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.DataAccess.Interfaces
{
	public interface IEmployee:IGenericRepository<Employee>
	{
        //Task<int> GetEmployeeCount();
        //Task<IEnumerable<EmployeeDto>> GetAllEmployee();

    }
}
