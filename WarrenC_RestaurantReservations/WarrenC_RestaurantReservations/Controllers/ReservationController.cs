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

        public static int ind;
        [HttpGet]
        public IActionResult EditReservation(int index)
        {
            ind = index;
            return View(reservations[index]);
        }

        [HttpPost]
        public IActionResult EditReservation(Reservation reservation)
        {
            reservations[ind] = reservation;
            return RedirectToAction("ViewReservations", "Reservation");
        }

        public static void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
        [HttpGet]
        public IActionResult ViewReservations()
        {
            return View(reservations);
        }
        [HttpGet]
        public IActionResult RemoveReservations(int index)
        {
            reservations.RemoveAt(index);
            return RedirectToAction("ViewReservations", "Reservation");
        }
    }
}