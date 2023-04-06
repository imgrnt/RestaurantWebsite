using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantWebsite.Controllers
{
    [Area("Admin")]
    public class ReservationController : Controller
    {

        private RestaurantContext context { get; set; }

        public ReservationController(RestaurantContext ctx)
        {
            context = ctx;
        }


        public IActionResult Index()
        {
            return RedirectToAction("ReserveList");
        }

        //[Route("[area]/[controller]s/{id?}")]
        public IActionResult ReserveList()
        {

            var reservation = context.Reservations
            .OrderBy(c => c.Id).ToList();
            return View(reservation);
        }



        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddUpdate", new Reservation());
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Action = "Update";
            var reservation = context.Reservations.Find(id);
            return View("AddUpdate", reservation);
        }



        [HttpPost]
        public IActionResult Update(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                if (reservation.Id == 0)
                {
                    context.Reservations.Add(reservation);
                }
                else
                {
                    context.Reservations.Update(reservation);
                }
                context.SaveChanges();
                return RedirectToAction("ReserveList");
            }
            else
            {
                ViewBag.Action = (reservation.Id == 0) ? "Add" : "Update";
                return View("AddUpdate");

            }
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var reservation = context.Reservations.Find(id);
            return View(reservation);
        }


        [HttpPost]
        public IActionResult Delete(Reservation reservation)
        {
            context.Reservations.Remove(reservation);
            context.SaveChanges();
            return RedirectToAction("ReserveList");
        }


    }
}

