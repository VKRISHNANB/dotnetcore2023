using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecondWebApi.Models;

namespace SecondWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private RepositoryEmployee _repositoryEmployee;

        public EmployeeController(RepositoryEmployee repository)
        {
            _repositoryEmployee = repository;
        }
        [HttpGet("/GetAllEmployees")]
        public IEnumerable<EmpViewModel> GetAllEmployees()
        {
            List<Employee> employees = _repositoryEmployee.AllEmployees();
            var empList = (
                    from emp in employees
                    select new EmpViewModel()
                    {
                        EmpId = emp.EmployeeId,
                        FirstName = emp.FirstName,
                        LastName = emp.LastName,
                        BirthDate = emp.BirthDate,
                        HireDate = emp.HireDate,
                        Title = emp.Title,
                        City = emp.City,
                        ReportsTo = emp.ReportsTo
                    }
                ).ToList();
            return empList;
        }
        [HttpGet("/FindEmployees")]
        public EmpViewModel FindEmployees(int id)
        {
            Employee? emp = _repositoryEmployee.FindEmployeeByID(id);
            var empView =
                    new EmpViewModel()
                    {
                        EmpId = emp.EmployeeId,
                        FirstName = emp.FirstName,
                        LastName = emp.LastName,
                        BirthDate = emp.BirthDate,
                        HireDate = emp.HireDate,
                        Title = emp.Title,
                        City = emp.City,
                        ReportsTo = emp.ReportsTo
                    };
            return empView;
        }
        [HttpPost("/AddNewEmployees")]
        public int AddNewEmployees(EmpViewModel newEmployee)
        {
            Employee emp = new Employee()
            {
                //EmployeeId=newEmployee.EmpId,
                FirstName = newEmployee.FirstName,
                LastName = newEmployee.LastName,
                BirthDate = newEmployee.BirthDate,
                HireDate=newEmployee.HireDate,
                Title = newEmployee.Title,
                City = newEmployee.City,
                ReportsTo = newEmployee.ReportsTo > 0? newEmployee.ReportsTo:null
            };
            int result = _repositoryEmployee.AddEmployee(emp);            
            return result;
        }
        [HttpPost("/ModifyEmployees")]
        public int ModifyEmployees(EmpViewModel empView)
        {
            Employee emp = new Employee()
            {
                EmployeeId = empView.EmpId,
                FirstName = empView.FirstName,
                LastName = empView.LastName,
                BirthDate = empView.BirthDate,
                HireDate = empView.HireDate,
                Title = empView.Title,
                City = empView.City,
                ReportsTo = empView.ReportsTo
            };
            int result = _repositoryEmployee.UpdateEmployee(emp);
            return result;
        }
        [HttpPost("/DeleteEmployees")]
        public int DeleteEmployees(int id)
        {
            int result = _repositoryEmployee.DeleteEmployee(id);
            return result;
        }
    }
}
