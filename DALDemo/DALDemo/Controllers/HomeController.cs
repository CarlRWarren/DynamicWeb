using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DALDemo.Models;
using DALDemo.Data;

namespace DALDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IZombieDAL zdbContext;
        List<Zombie> zeds;
        public HomeController(IZombieDAL context) : base()
        {
            zdbContext = context;
        }
        public IActionResult Index()
        {
            Zombie z = zdbContext.GetZombieByIndex(new Random().Next(zdbContext.GetZombieCount()));
            return View(z);
        }
        public IActionResult AboutZeds()
        {
            return View();
        }

        public IActionResult DisplayZeds()
        {
            zeds = zdbContext.GetAllZombies().ToList();
            return View(zeds);
        }
    }
}