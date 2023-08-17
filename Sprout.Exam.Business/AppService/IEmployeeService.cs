using Sprout.Exam.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.Business.AppService
{
    public interface  IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployees();

        Task<EmployeeDto> GetEmployeeById(int id);

        Task UpdateEmployee(EditEmployeeDto editEmployeeDto);
        Task DeleteEmployee(int id);

        Task<EmployeeDto> CreateEmployee(CreateEmployeeDto createEmployeeDto);

        Task<string> CalculateSalary(int id, decimal absentDays, decimal workedDays);
    }
}
