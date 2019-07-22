using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameLibraryPt1.Models;

namespace VideoGameLibraryPt1.Controllers
{
    public class HomeController : Controller
    {
        private static List<Game> games = new List<Game>()
        {
            new Game(){Title="Dishonored", Platform="PS3", Genre="Stealth Action-Adventure", EsrbRating="RP", ReleaseDate=2012, Image="dishonored.jpg"},
            new Game(){Title="Dead by Daylight", Platform="PC", Genre="Asymmetric Survival Horror", EsrbRating="M", ReleaseDate=2016, Image="deadbydaylight.jpg"},
            new Game(){Title="Dead by Daylight", Platform="PS4", Genre="Asymmetric Survival Horror", EsrbRating="M", ReleaseDate=2016, Image="deadbydaylight.jpg"},
            new Game(){Title="Binding of Isaac", Platform="Switch", Genre="Indie Roguelike", EsrbRating="M", ReleaseDate=2011, Image="bindingofisaac.jpg"},
            new Game(){Title="Pokemon Mystery Dungeon: Darkness", Platform="DS", Genre="Roguelike, Role-playing", EsrbRating="E10+", ReleaseDate=2007, Image="pokemonmysterydarkness.jpg"},
            new Game(){Title="Puzzle Quest: Challenge of Warlords", Platform="PS2", Genre="Puzzle, Tile-matching, Role-playing", EsrbRating="E10+", ReleaseDate=2007, Image="dishonored.jpg"},
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayGames()
        {
            return View(games);
        }
    }
}