using System.ComponentModel.DataAnnotations;

namespace Employee_Api.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string LastName { get; set; }

        public string Mobile { get; set; }
    }
}
