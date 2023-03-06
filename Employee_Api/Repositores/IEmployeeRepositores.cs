using Employee_Api.Models;
using System.Collections;

namespace Employee_Api.Repositores
{
    public interface IEmployeeRepositores
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<IEnumerable<Employee>> GetEmployees(int id);
        Task PostEmployee(Employee employee);
        Task PutEmployee(int id, Employee employee);
        Task DeleteEmployee(int id);
    }
}
