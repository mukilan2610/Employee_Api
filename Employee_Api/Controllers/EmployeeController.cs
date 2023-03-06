using Employee_Api.Services;
using Employee_Api.Models;
using Employee_Api.Repositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employee_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepositores employeeServices;
        private readonly ILogger<EmployeeController> logger;
        private IEmployeeRepositores employeeRepositores;

        public EmployeeController(IEmployeeRepositores _employeeServices, ILogger<EmployeeController> _logger)
        {
            employeeServices = _employeeServices;
            logger = _logger;

        }

       

        [HttpPost]
        [Route("PostEmployee")]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            try
            {
                await employeeServices.PostEmployee(employee);
                return Ok("Employee Added");
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong inside PostEmployee action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        //public async Task<ActionResult<Employee>> PostEmployee( [FromBody]Employee employee)
        //{
        //    try
        //    {
        //        await employeeServices.PostEmployee(employee);
        //        return Ok(employee);
        //    }
        //    catch 
        //    {
        //        return Ok("Error");
        //    }
        //}
       
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployees(int id)
        {
            try
            {
                var prd = await employeeServices.GetEmployees(id);
                return Ok(prd);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong inside GetProduct action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet]
        public async Task<ActionResult<Employee>> GetAll()
        {
            try
            {
                var prd = await employeeServices.GetAll();
                return Ok(prd);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong inside GetProduct action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }



        [HttpPut]
        [Route("PutEmployee")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            try
            {
                await employeeServices.PutEmployee(id, employee);
                return Ok("Employee Updated");
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong inside PutProduct action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }


     
      


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            try
            {
                await employeeServices.DeleteEmployee(id);
                return Ok("Employee Deleteed");
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong inside PostProduct action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        private bool EmployeExit(int id)
        {
            return false;
        }
    }
}
