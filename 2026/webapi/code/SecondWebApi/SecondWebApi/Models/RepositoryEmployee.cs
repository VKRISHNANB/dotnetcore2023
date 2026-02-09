using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;
using System;

namespace SecondWebApi.Models
{
    public class RepositoryEmployee
    {
        private NorthwindContext _context;
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }

        public List<Employee> AllEmployees()
        {

            return _context.Employees.ToList();
        }
        public Employee? FindEmployeeByID(int id)
        {

            return _context.Employees.Find(id);
        }
        public Employee? FindEmployeeManager(int id)
        {
            Employee? emp = _context.Employees.Find(id);
            int? managerID = 0;
            if (emp != null)
            {
                managerID = emp.ReportsTo;
            }
            Employee? manager = null;
            if (managerID != 0)
            {
                manager = _context.Employees.Find(managerID);
            }
            #region
            //Employee? manager1 = _context.Employees
            //    .Include(d => d.ReportsToNavigation)
            //    .FirstOrDefault(x => x.EmployeeId == id);
            #endregion
            return manager;
        }
        public int AddEmployee(Employee employee)
        {
            Employee? foundEmp = _context.Employees.Find(employee.EmployeeId);
            if (foundEmp != null)
            {
                throw new Exception("Failed to add Employee.Duplicate Id");
            }
            EntityState es = _context.Entry(employee).State;
            Console.WriteLine($"EntityState B4Add : {es.GetDisplayName()}");
            _context.Employees.Add(employee);
            es = _context.Entry(employee).State;
            Console.WriteLine($"EntityState After Add : {es.GetDisplayName()}");
            int result = _context.SaveChanges();
            es = _context.Entry(employee).State;
            Console.WriteLine($"EntityState After SaveChanges : {es.GetDisplayName()}");
            return result;
        }

        public int UpdateEmployee(Employee modifiedEmployee)
        {
            EntityState es = _context.Entry(modifiedEmployee).State;
            Console.WriteLine($"EntityState B4Update : {es.GetDisplayName()}");
            _context.Employees.Update(modifiedEmployee);
            es = _context.Entry(modifiedEmployee).State;
            Console.WriteLine($"EntityState After Update : {es.GetDisplayName()}");
            int result = _context.SaveChanges();
            es = _context.Entry(modifiedEmployee).State;
            Console.WriteLine($"EntityState After SaveChanges : {es.GetDisplayName()}");
            return result;
        }
        public int DeleteEmployee(int id)
        {
           
            Employee empToDelete = _context.Employees.Find(id);
            EntityState es = EntityState.Detached;
            int result = 0;
            if (empToDelete != null)
            {
                es = _context.Entry(empToDelete).State;
                Console.WriteLine($"EntityState B4Update : {es.GetDisplayName()}");
                _context.Employees.Remove(empToDelete);
                es = _context.Entry(empToDelete).State;
                Console.WriteLine($"EntityState After Update : {es.GetDisplayName()}");
                result = _context.SaveChanges();
                es = _context.Entry(empToDelete).State;
                Console.WriteLine($"EntityState After SaveChanges : {es.GetDisplayName()}");
            }
            return result;
        }
    }
}
