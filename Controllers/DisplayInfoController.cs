using DBFirstProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstProject.Controllers
{
    public class DisplayInfoController : Controller
    {

        public EmployeeDbContext employeeDbContext { get; set; }    
        public DisplayInfoController(EmployeeDbContext _employeeDbContext)
        {
            employeeDbContext = _employeeDbContext;
        }

        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>();
            var d = employeeDbContext.Employees.ToList();


                return View(employees);
        }
    }
}
