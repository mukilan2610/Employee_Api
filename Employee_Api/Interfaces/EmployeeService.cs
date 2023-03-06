using Employee_Api.Models;

namespace Employee_Api.Services
{
    public class EmployeeService : IEmployeeServices
    {
        public readonly IEmployeeServices _employeeRepo;
        public EmployeeService (IEmployeeServices employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public async Task DeleteEmployee(int id)
        {
           await _employeeRepo.DeleteEmployee(id);
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await _employeeRepo.GetEmployee();
        }

        public async Task<IEnumerable<Employee>> GetEmployee(int id)
        {
            return await _employeeRepo.GetEmployee(id);
        }

        public async Task PostEmployee(Employee employee)
        {
            await _employeeRepo.PostEmployee(employee);
        }

        public async Task PutEmployee(int id, Employee employee)
        {
            await _employeeRepo.PutEmployee(id, employee);
        }
    }
}
