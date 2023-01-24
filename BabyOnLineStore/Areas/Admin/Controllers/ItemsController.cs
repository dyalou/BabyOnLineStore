using BabyOnLineStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BabyOnLineStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ItemsController : Controller
    {
        // passing data till database throw a cunstractor
        private AppDbContext _db;

        public ItemsController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Items.Include(c => c.ProductTypes).ToList());
        }
    }
}
