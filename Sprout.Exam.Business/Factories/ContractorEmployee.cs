using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.Business.Factories
{
    public class ContractorEmployee : IEmployeeSalaryFactory
    {
        protected const decimal rate = 500;
        public decimal CalculateSalary(decimal ptoDays, decimal workDays)
        {
            var output = rate * workDays;
          return  decimal.Round(output,2);
        }
    }
}