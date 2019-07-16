using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReusableComponentsDemo.Models;

namespace ReusableComponentsDemo.Controllers
{
    public class HomeController : Controller
    {
        private static List<Zombie> zeds = new List<Zombie>()
        {
            new Zombie() {ZedType="Walker", NumberOfArms=2, NumberOfLegs=2},
            new Zombie() {ZedType="Pirate", NumberOfArms=2, NumberOfLegs=1, ImageName="Pirate.jpg"}
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutZeds()
        {
            return View();
        }

        public IActionResult DisplayZeds()
        {
            return View(zeds);
        }
    }
}