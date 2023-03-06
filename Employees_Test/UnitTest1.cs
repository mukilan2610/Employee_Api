//using Employee_Api.Controllers;
//using Employee_Api.Models;
//using Employee_Api.Repositores;
//using Employees_Test;
//using FluentAssertions;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
//using MySqlX.XDevAPI;
//using NuGet.Protocol.Core.Types;
//using System;
//using System.Web.Mvc;
//using Xunit;

//namespace employees_test
//{
//    public class unittest1
//    {
//        private readonly EmployeeRepositores _employeeRepositores;
//        public unittest1(EmployeeRepositores employeeRepositores)
//        {
//            _employeeRepositores = employeeRepositores;
//        }


//        [Fact]
//        public async void PostEmployee()
//        {
//            //var employee = new unittest1(_employeeRepositores);
//            //var post = new Employee()
//            //{
//            //    Firstname = "mukilan",
//            //    LastName = "mukilan",
//            //    Mobile = "9150135396"
//            //};
//            var controller = new EmployeeController(_employeeRepositores);
//            var post = new Employee() { Id = 1,Firstname = "Mukilan", LastName = "Mukilan", Mobile = "9150135396" };

//            //Act  
//            var data =  _employeeRepositores.PostEmployee(post);

//            //Assert  
//            Assert.IsType<OkObjectResult>(data);

//            var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
//            // var result = okResult.Value.Should().BeAssignableTo<PostViewModel>().Subject;  

//            Assert.Equal(3, okResult.Value);
//            //Guid guid = Guid.NewGuid();

//            //Employee model = new Employee()
//            //{

//            //    Firstname = "testName",
//            //    LastName = "test email",
//            //    Mobile = "test phone"

//            //};

//            //var actionResult = _employeeRepositores.PostEmployee(model);

//            //Assert.NotNull(actionResult);
//            //Assert.IsType<Task<IActionResult>>(actionResult);
//            //Assert.True(actionResult.IsCompletedSuccessfully);



//        }


//    }
//}