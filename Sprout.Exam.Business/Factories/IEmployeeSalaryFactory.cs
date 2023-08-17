using System.Threading.Tasks;

namespace Sprout.Exam.Business.Factories
{
    public interface IEmployeeSalaryFactory
    {
        decimal CalculateSalary(decimal ptoDays, decimal workDays);
    }
}