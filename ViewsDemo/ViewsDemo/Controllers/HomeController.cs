using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewsDemo.Models;
namespace ViewsDemo.Controllers
{
    public class HomeController : Controller
    {
        private static List<Movie> AllMovies { get; set; } = new List<Movie>()
        {
            new Movie() {Title="Darkest Hour", Year=2012, StarRating=7.8f},
            new Movie() {Title="InTime", Year=2011, StarRating=6.7f},
            new Movie() {Title="John Wick 3", Year=2019, StarRating=8.0f}
        };
        public IActionResult Index()
        {
            //Model: Model= Named Argument
            return View(AllMovies);
        }

        public IActionResult Display(int index)
        {
            Movie movieModel = index < AllMovies.Count ? AllMovies[index] : null;
            
            return View(movieModel);
        }
    }
}