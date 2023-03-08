﻿using EmployeesMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesMvc.Controllers
{
    public class HomeController : Controller
    {
        static DataService dataService = new();

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(dataService.GetAll());
        }

        [HttpGet("/create")]
        public IActionResult CreateEmployee()
        {
            
            return View();
        }

        [HttpPost("/create")]
        public IActionResult CreateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            dataService.AddEmployee(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
