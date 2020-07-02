using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        EmployeeContext db;
        public HomeController(EmployeeContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            db.Employees.Add(employee);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details (int? id)
        {
            if(id != null)
            {
                Employee employee = db.Employees.FirstOrDefault(prop => prop.Id == id);
                if (employee != null)
                    return View(employee);
            }
            return NotFound();
        }
    }
}