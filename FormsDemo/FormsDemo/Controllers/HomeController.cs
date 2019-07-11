using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormsDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormsDemo.Controllers
{
    public class HomeController : Controller
    {
        private static List<Zombie> zombies = new List<Zombie>();
        public IActionResult Index()
        {
            return View(zombies);
        }

        public static void AddZombie(Zombie zombie)
        {
            zombies.Add(zombie);
        }
    }
}