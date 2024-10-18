using Microsoft.AspNetCore.Mvc;

namespace FirstMVC
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {            
            return View();
        }
        public IActionResult Create()
        {            
            return View(new Employee());
        }
       [HttpPost] 
       public IActionResult AddEmp(Employee employee)
        {
            //if(employee==null)
            //{
            //    ModelState.AddModelError("NullModel",
            //     "Model Is Null");
            //}
            // if (string.IsNullOrEmpty(employee.FirstName)) {
            //     ModelState.AddModelError(nameof(employee.FirstName),
            //     "Please enter your Firstname");
            // }
            //  if (string.IsNullOrEmpty(employee.LastName)) {
            //     ModelState.AddModelError(nameof(employee.LastName),
            //     "Please enter your Lastname");
            // }
            if (ModelState.IsValid) {
                return View(employee);
            } else {
                return View("Create",employee);
            }
        }
    }
}