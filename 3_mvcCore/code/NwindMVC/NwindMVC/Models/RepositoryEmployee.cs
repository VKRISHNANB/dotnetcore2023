namespace NwindMVC.Models
{
    public class RepositoryEmployee
    {
        private NorthwindContext _context;
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }

        public  List<Employee> AllEmployees() {
            return _context.Employees.ToList();
        }
    }
}
