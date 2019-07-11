using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarrenC_RestaurantReservations.Models;

namespace WarrenC_RestaurantReservations.Controllers
{
    public class ReservationController : Controller
    {
        private static List<Reservation> reservations = new List<Reservation>();

        [HttpGet]
        public IActionResult CreateReservation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateReservation(Reservation reservation)
        {
            AddReservation(reservation);
            return RedirectToAction("Index", "Home");
        }

        public static void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public static void RemoveReservation(Reservation reservation)
        {
            reservations.Remove(reservation);
        }

        public IActionResult ViewReservations()
        {
            return View(reservations);
        }
    }
}