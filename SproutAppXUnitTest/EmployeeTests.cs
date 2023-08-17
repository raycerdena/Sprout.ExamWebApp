using System;
using Xunit;
using Moq;
using FizzWare.NBuilder;
using Sprout.Exam.Business.AppService;
using Sprout.Exam.WebApp.Controllers;
using System.Collections;
using System.Threading.Tasks;
using Sprout.Exam.Business.DataTransferObjects;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace SproutAppXUnitTest
{
    public class EmployeeTest
    {
        private readonly Mock<IEmployeeService> _employeeServiceMock;
        private readonly Mock<EmployeesController> _employeesControllerMock;


        public EmployeeTest()
        {
            _employeeServiceMock = new Mock<IEmployeeService>();
            _employeesControllerMock = new Mock<EmployeesController>();

        }
        [Fact]
        public async Task GetAll_Employee_Test()
        {
            //Arrange
            var employees = EmployeeData();
            _employeeServiceMock.Setup(e=>e.GetAllEmployees()).Returns(Task.FromResult(employees));
            var employeeController = new EmployeesController(_employeeServiceMock.Object);

            //Act
            var actionResults = await employeeController.Get();
            var results = actionResults as ObjectResult;
         

            var jsonData = JsonConvert.SerializeObject(results.Value);
            var employeeData= JsonConvert.SerializeObject(employees);

            //Assert
            Assert.NotNull(results);
            Assert.True(employeeData.Equals(jsonData));
        }

        private IEnumerable<EmployeeDto> EmployeeData()
        {

            return Builder<EmployeeDto>.CreateListOfSize(3).Build().ToList();

        }
    }
}
