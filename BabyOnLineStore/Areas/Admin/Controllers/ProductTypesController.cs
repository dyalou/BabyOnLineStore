﻿using BabyOnLineStore.Data;
using BabyOnLineStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace BabyOnLineStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        // passing data till database throw a cunstractor
        private AppDbContext _db;

        public ProductTypesController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            return View(_db.ProductTypes.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        //POST Create Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ItemsList productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.ProductTypes.Add(productTypes);
                await _db.SaveChangesAsync();
                //TempData["save"] = "Product type has been saved";
                return RedirectToAction(nameof(Index));
            }

            return View(productTypes);
        }
        //GET Edit Action Method

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }

        //POST Edit Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ItemsList productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(productTypes);
                await _db.SaveChangesAsync();
                TempData["edit"] = "Product type has been updated";
                return RedirectToAction(nameof(Index));
            }

            return View(productTypes);
        }


        //GET Details Action Method

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }

        //POST Edit Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ItemsList productTypes)
        {
            return RedirectToAction(nameof(Index));

        }

        //GET Delete Action Method

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }

        //POST Delete Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, ItemsList productTypes)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (id != productTypes.Id)
            {
                return NotFound();
            }

            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(productType);
                await _db.SaveChangesAsync();
                TempData["delete"] = "Product type has been deleted";
                return RedirectToAction(nameof(Index));
            }

            return View(productTypes);
        }


    }
}
