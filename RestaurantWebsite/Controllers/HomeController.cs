﻿using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Models;
using System.Diagnostics;

namespace RestaurantWebsite.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        private RestaurantContext context { get; set; }

        public HomeController(RestaurantContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Reserve()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Menu()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Reserve(Reservation appointment)
        {
            if (ModelState.IsValid)
            {
                context.Reservations.Add(appointment);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {

                return View(appointment);
            }
        }

        




        public IActionResult Shop()
        {
            var food = context.Foods.OrderBy(m => m.FoodId).ToList();
            return View(food);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}