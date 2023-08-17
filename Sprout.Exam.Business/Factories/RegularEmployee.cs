using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.Business.Factories
{
    public class RegularEmployee:IEmployeeSalaryFactory
    {

      
        protected const decimal basicPay = 20000;
        public decimal CalculateSalary(decimal ptoDays, decimal workDays) {
            decimal taxRate= 0.12M;
            return decimal.Round(basicPay -(ptoDays* (basicPay / 22)) - (basicPay * taxRate),2);
        }
    }
}
