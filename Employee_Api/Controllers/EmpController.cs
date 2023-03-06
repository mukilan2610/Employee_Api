using Employee_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        EmployeeDBContext _dbContext;
        public EmpController(EmployeeDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<Employee> GetAll()
        {
            var employee = _dbContext.Employees.ToList();
            return employee;
        }
       
    }
}
