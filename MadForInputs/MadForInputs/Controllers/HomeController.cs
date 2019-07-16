using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadForInputs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadForInputs.Controllers
{
    public class HomeController : Controller
    {
        private static List<string> wordInputs = new List<string>();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MadLibForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MadLibForm(Madlib madlib)
        {
            wordInputs.AddRange(madlib.MadlibToList());
            return RedirectToAction("DisplayMadLib", "Home");
        }

        public IActionResult DisplayMadLib()
        {
            return View(wordInputs);
        }
    }
}