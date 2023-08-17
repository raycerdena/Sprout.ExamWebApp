using Sprout.Exam.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.Business.Factories
{
	public abstract class EmployeeSalaryFactory
	{
        public abstract IEmployeeSalaryFactory GetEmployeeSalary(int id);


    }
}
