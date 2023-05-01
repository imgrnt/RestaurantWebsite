using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Models;

namespace RestaurantWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ImageController : Controller
    {
        private RestaurantContext context { get; set; }

        private readonly IWebHostEnvironment WebHostEnvironment;

        public ImageController(RestaurantContext ctx, IWebHostEnvironment webHostEnvironment)
        {
            context = ctx;
            WebHostEnvironment = webHostEnvironment;
        }

        // GET: ImageController
        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction("ImageList");
        }


        // GET: ImageController/ImageList
        [HttpGet]
        public IActionResult ImageList()
        {
            var items = context.Images.ToList();
            return View(items);
        }

        // GET: ImageController/Create
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        // POST: ImageController/Create
        [HttpPost]
        public IActionResult Create(ImageViewModel vm)
        {
            string stringFileName = UploadFile(vm);
            var image = new Image
            {
                ImageName = vm.ImageName,
                FileName = stringFileName
            };

            context.Images.Add(image);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        private string UploadFile(ImageViewModel vm)
        {
            string fileName = null;
            if(vm.FileName!=null)
            {
                string uploadDir = Path.Combine(WebHostEnvironment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + "-" + vm.FileName.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using(var fileStream = new FileStream(filePath,FileMode.Create))
                {
                    vm.FileName.CopyTo(fileStream);
                }

            }
            return fileName;

        }



        // GET: ImageController/Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Update";
            var image = context.Images.Find(id);
            return View("Edit", image);
        }




    }
}


/*
 * 
 * 
 * 


            var images = new List<string>();
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "wwwroot", "images");

            foreach (var file in Directory.GetFiles(imagePath))
            {
                images.Add($"~/wwwroot/images/{Path.GetFileName(file)}");
            }

 */