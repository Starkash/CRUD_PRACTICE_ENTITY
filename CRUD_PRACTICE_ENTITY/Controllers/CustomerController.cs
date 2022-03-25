using CRUD_PRACTICE_ENTITY.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_PRACTICE_ENTITY.Controllers
{
    public class Customer : Controller
    {
        private ApplicationDbContext dbContext;
        public Customer(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Location> loc = dbContext.Locations.ToList();

            return View(loc);
        }
    }
}
