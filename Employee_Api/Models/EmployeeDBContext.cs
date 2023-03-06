using Microsoft.EntityFrameworkCore;

namespace Employee_Api.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
