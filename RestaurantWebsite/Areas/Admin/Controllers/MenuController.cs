using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Models;

namespace RestaurantWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        private RestaurantContext context { get; set; }

        public MenuController(RestaurantContext ctx)
        {
            context = ctx;
        }


        // GET: MenuController
        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction("MenuList");
        }


        // GET: MenuController/MenuList
        [HttpGet]
        public IActionResult MenuList()
        {
            var food = context.Foods
            .OrderBy(c => c.FoodId).ToList();
            return View(food);
        }

        // GET: MenuController/Add
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddUpdate", new Food());
        }

        // GET: MenuController/Update
        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Action = "Update";
            var food = context.Foods.Find(id);
            return View("AddUpdate", food);
        }

        // POST: MenuController/Update
        [HttpPost]
        public IActionResult Update(Food item)
        {
            if (ModelState.IsValid)
            {
                if (item.FoodId== 0)
                {
                    context.Foods.Add(item);
                }
                else
                {
                    context.Foods.Update(item);
                }
                context.SaveChanges();
                return RedirectToAction("MenuList");
            }
            else
            {
                ViewBag.Action = (item.FoodId == 0) ? "Add" : "Update";
                return View("AddUpdate");

            }
        }

        // GET: MenuController/Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = context.Foods.Find(id);
            return View(item);
        }

        // POST: MenuController/Delete
        [HttpPost]
        public IActionResult Delete(Food item)
        {
            context.Foods.Remove(item);
            context.SaveChanges();
            return RedirectToAction("MenuList");
        }
    }
}
