using Microsoft.EntityFrameworkCore;
using Sprout.Exam.DataAccess.Interfaces;
using Sprout.Exam.DataAccess.Entities;
using Sprout.Exam.DataAccess.SproutDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.DataAccess.Repositories
{	
	public class EmployeeRepository: GenericRepository<Employee>, IEmployee
	{
	
		public EmployeeRepository(SproutDBContext cntxt) : base(cntxt)
		{
	
		}

        


    }
}
