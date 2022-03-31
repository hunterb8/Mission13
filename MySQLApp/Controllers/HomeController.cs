using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySQLApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLApp.Controllers
{
    public class HomeController : Controller
    {
        private IBowlerRepository _repo { get; set; }

        //Constructor
        public HomeController(IBowlerRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var blah = _repo.Bowlers
                .ToList();

            return View(blah);
        }

        [HttpGet]
        public IActionResult AddEditBowler()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEditBowler(Bowler b)
        {
            _repo.AddBowler(b);
            _repo.SaveChanges();
            
            return View("Confirmation", b);
        }
    }
}
