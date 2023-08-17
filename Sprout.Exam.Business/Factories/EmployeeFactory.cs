using Sprout.Exam.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.Business.Factories
{
    public class EmployeeFactory : EmployeeSalaryFactory
    {
        public override IEmployeeSalaryFactory GetEmployeeSalary(int id)
        {
            switch (id)
            {
                case (int)EmployeeType.Contractual:
                    return new ContractorEmployee();
                case (int)EmployeeType.Regular:
                    return new RegularEmployee();
                default:
                    throw new ApplicationException(string.Format("Employee type '{0}' cannot be calculated", id));
            }

        }
    }
}

