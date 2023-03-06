using Employee_Api.Models;

namespace Employee_Api.Services
{
    public interface IEmployeeServices
    {
        public Task<IEnumerable<Employee>> GetEmployee();
        public Task<IEnumerable<Employee>> GetEmployee(int id);
        public Task PutEmployee(int id, Employee employee);
        public Task PostEmployee(Employee employee);
        public Task DeleteEmployee(int id);
    }
}
