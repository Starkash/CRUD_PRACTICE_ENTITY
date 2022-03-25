using CRUD_PRACTICE_ENTITY.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_PRACTICE_ENTITY.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContext;
        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Employee> employees = dbContext.Employees.ToList();
            return View(employees);        }
        [HttpGet]
        

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                dbContext.Employees.Add(emp);
                dbContext.SaveChanges();
                return Redirect("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.Id == id);
            return View(emp);
            
        }
       [HttpPost]
        
        public IActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                dbContext.Employees.Update(emp);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
           
            
        }



    } 
}
