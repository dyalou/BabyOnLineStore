using BabyOnLineStore.Data;
using BabyOnLineStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;


namespace BabyOnLineStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ItemsController : Controller
    {
        // passing data till database throw a cunstractor
        private AppDbContext _db;
        private IHostEnvironment _he;




        public ItemsController(AppDbContext db, IHostEnvironment he)
        {
            _db = db;
            _he = he;
        }

        public IActionResult Index()
        {
            return View(_db.Items.Include(c => c.ItemsList).ToList());


        }

        [HttpPost]
        public IActionResult Index(double? lowAmount, double? largeAmount)
        {
            var items = _db.Items.Include(c => c.ItemsList).ToList();
            if (lowAmount == null || largeAmount == null)
            {
                items = _db.Items.Include(c => c.ItemsList).ToList();
            }
            return View(items);
        }

        public IActionResult Create()
        {
            //These SelectList objects are used to create drop-down lists in the view. The _db.ProductTypes.ToList() retrieves all the product types from the database 
            //ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");

            return View();
        }


        //Post Create method
        [HttpPost]
        public async Task<IActionResult> Create(Items items, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                // search if the item with thre same name is existet in the database, if not create  and add to the list
                //var searchProduct = _db.Items.FirstOrDefault(c => c.ItemName == items.ItemName);
                //if (searchProduct != null)
                //{
                //    ViewBag.message = "This product is already exist";
                //    ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");

                //    return View(items);
                //}
                ////If an image was uploaded, it creates a file path for the image and copies the image to that path.
                ////It then assigns the file path to the "Image" property of the "items" object.

                //if (image != null)
                //{
                //    var filePath = Path.Combine("Images", Path.GetFileName(image.FileName));
                //    var name = Path.Combine(_he.ContentRootFileProvider.GetFileInfo(filePath).PhysicalPath);
                //    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                //    items.Image = "Images/" + image.FileName;
                //}
                ////If an image was not uploaded, it assigns a default image to the "Image" property of the "items" object.
                //if (image == null)
                //{
                //    items.Image = "Images/noimage.PNG";
                //}
                _db.Items.Add(items);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(items);
        }

    }
}
