using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormsDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormsDemo.Controllers
{
    public class ZombieController : Controller
    {
        [HttpGet]//permission gate
        public IActionResult CreateZombie()
        {
            //if the query string contains an index value, add it to ViewBag.Index
            //Otherwise, set ViewBag.Index to -1
            ViewBag.Index = -1;
            return View();
        }
        //[HttpPost]
        //public IActionResult CreateZombie(string name, string zedType, int hoursUndead)
        //{
        //    Zombie zombie = new Zombie() { Name = name, ZedType = zedType, HoursUndead = hoursUndead };
        //    HomeController.AddZombie(zombie);
        //    return RedirectToAction("Index", "Home");
        //}
        [HttpPost]
        public IActionResult CreateZombie(Zombie zombie)
        {
            //int hours = int.Parse(Request.Form["hoursUndead"]);//get data from form
            //Zombie zombie = new Zombie() { Name = name, ZedType = zedType, HoursUndead = hoursUndead };
            HomeController.AddZombie(zombie);
            return RedirectToAction("Index", "Home");
        }
    }
}