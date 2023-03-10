using EmployeesMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesMvc.Controllers
{
    public class HomeController : Controller
    {
        IDataService dataService;

        public HomeController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet("/")]
        public async Task<IActionResult> Index()
        {
            return View(await dataService.GetAll());
        }

        [HttpGet("/create")]
        public IActionResult CreateEmployee()
        {
            
            return View();
        }

        [HttpPost("/create")]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await dataService.AddEmployee(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
