using Sprout.Exam.Business.DataTransferObjects;
using Sprout.Exam.Business.Factories;
using Sprout.Exam.Common.Enums;
using Sprout.Exam.DataAccess.Entities;
using Sprout.Exam.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.Business.AppService
{
    public class EmployeeService : IEmployeeService
    {
        public IEmployee _employee;
        public EmployeeService(IEmployee employee)
        {
            _employee = employee;
        }


        public async Task<EmployeeDto> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            var employee = new Employee
            {
                Birthdate = createEmployeeDto.Birthdate,
                FullName = createEmployeeDto.FullName,
                Tin = createEmployeeDto.Tin,
                EmployeeTypeId = createEmployeeDto.TypeId
            };
            var result = await _employee.InsertAsync(employee);

            return new EmployeeDto
            {
                Birthdate = result.Birthdate.ToShortDateString(),
                FullName = result.FullName,
                Tin = result.Tin,
                TypeId = result.EmployeeTypeId

            };
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployees()
        {

            var employees = await _employee.GetAllAsync();

            return employees.Where(e => e.IsDeleted == false).Select(e => new EmployeeDto
            {
                Id = e.Id,
                Birthdate = e.Birthdate.ToShortDateString(),
                FullName = e.FullName,
                Tin = e.Tin,
                TypeId = e.EmployeeTypeId
            });

        }


        public async Task<EmployeeDto> GetEmployeeById(int id)
        {

            var employees = await _employee.GetByIdAsync(id);

                return new EmployeeDto
            {
                Id = employees.Id,
                Birthdate = employees.Birthdate.ToString("MM/dd/yyyy"),
                FullName = employees.FullName,
                Tin = employees.Tin,
                TypeId = employees.EmployeeTypeId
            };

        }

        public async Task UpdateEmployee(EditEmployeeDto dto)
        {
            var employee = new Employee
            {
                Id = dto.Id,
                Birthdate = dto.Birthdate.Date,
                FullName = dto.FullName,
                Tin = dto.Tin,
                EmployeeTypeId = dto.TypeId
            };

            await _employee.UpdateAsync(employee);
        }

        public async Task DeleteEmployee(int id)
        {
            var employee = await _employee.GetByIdAsync(id);
            employee.IsDeleted = true;
            await _employee.UpdateAsync(employee);
        }

        public async Task<string> CalculateSalary(int id, decimal ptoDays, decimal workedDays) {

            var employee = await _employee.GetByIdAsync(id);

            EmployeeSalaryFactory factory = new EmployeeFactory();

            IEmployeeSalaryFactory employeeSalary = factory.GetEmployeeSalary(employee.EmployeeTypeId);
           
            return  employeeSalary.CalculateSalary(ptoDays, workedDays).ToString(); 
        }
    }
}
