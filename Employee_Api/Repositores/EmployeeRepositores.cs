using Employee_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mysqlx;
using MySqlX.XDevAPI.Common;
using System.Collections.Generic;

namespace Employee_Api.Repositores
{
    public class EmployeeRepositores : IEmployeeRepositores
    {
        public readonly EmployeeDBContext _dBContext;
        public EmployeeRepositores(EmployeeDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public async Task DeleteEmployee(int id)
        {
            var result = await _dBContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            _dBContext.Employees.Remove(result);
            await _dBContext.SaveChangesAsync();
        }

        //public async Task<IEnumerable<Employee>> GetEmployees()
        //{

        //    //var PLst = await (from pl in _dBContext.Employees
        //    //                  select new
        //    //                  {
        //    //                      pl.Id,
        //    //                      pl.Firstname,
        //    //                      pl.LastName,
        //    //                      pl.Mobile,

        //    //                  }).ToListAsync();

        //    //List<Employee> lst = new List<Employee>();
        //    //Employee pi = new Employee();
        //    //foreach (var item in PLst)
        //    //{
        //    //    pi = new Employee();
        //    //    pi.Id = Convert.ToInt32(item.Id);
        //    //    pi.Firstname = item.Firstname;
        //    //    pi.LastName = item.LastName;
        //    //    pi.Mobile = item.Mobile;


        //    //    lst.Add(pi);
        //    //}

        //    //return (IEnumerable<Employee>)lst;

        //    {
        //        List<Employee> inventories = new List<Employee>();
        //        inventories = _dBContext.Employees.ToList();
        //        return (IEnumerable<Employee>)inventories;
        //    }



        //}
        [HttpGet]
        [Route("GetAll")]

        public async Task<IEnumerable<Employee>> GetAll()
        {
           
            {
                List<Employee> inventories = new List<Employee>();
                inventories = _dBContext.Employees.ToList();
                return (IEnumerable<Employee>)inventories;
            }
           
        }

        public async Task<IEnumerable<Employee>> GetEmployees(int id)
        {
            var PLst = await (from pl in _dBContext.Employees
                              where pl.Id.Equals(id)
                              select new
                              {
                                  pl.Id,
                                  pl.Firstname,
                                  pl.LastName,
                                  pl.Mobile,

                              }).OrderByDescending(n => n.Id).ToListAsync();

            List<Employee> lst = new List<Employee>();
            Employee pi = new Employee();
            foreach (var item in PLst)
            {
                pi = new Employee();
                pi.Id = Convert.ToInt32(item.Id);
                pi.Firstname = item.Firstname;
                pi.LastName = item.LastName;
                pi.Mobile = item.Mobile;


                lst.Add(pi);
            }

            return (IEnumerable<Employee>)lst;
            // var result = await _dBContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            //return  (IEnumerable<Employee>)result;
        }

        public async  Task PostEmployee(Employee employee)
        {
            var result = new Employee()
            {
                Firstname = employee.Firstname,
                LastName = employee.LastName,
                Mobile = employee.Mobile
            };
            _dBContext.Add(result);
            await _dBContext.SaveChangesAsync();
          
        }
         
        public async Task PutEmployee(int id, Employee employee)
        {
            var result = await _dBContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if(result != null)
            {
                result.Firstname = employee.Firstname;
                result.LastName = employee.LastName;
                result.Mobile = employee.Mobile;
                await _dBContext.SaveChangesAsync();
            }
            

        }
    }
}
