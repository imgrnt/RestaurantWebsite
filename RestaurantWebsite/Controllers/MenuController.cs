using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Models;
using System.Diagnostics;

namespace RestaurantWebsite.Controllers
{
    public class MenuController : Controller
    {

        private RestaurantContext context { get; set; }

        public MenuController(RestaurantContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("MenuList", "Menu");
        }

        [HttpGet]
        public IActionResult MenuList()
        {
            var images = context.Images.OrderBy(c => c.ImageId).ToList();

            List<Food> foods;


            foods = context.Foods
                .OrderBy(c => c.FoodId).ToList();

            // use ViewBag to pass data to view
            ViewBag.Images = images;
            //ViewBag.SelectedImageName = id;


            return View(foods);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}