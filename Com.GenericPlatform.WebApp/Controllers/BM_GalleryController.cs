using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Com.GenericPlatform.WebApp.Controllers
{
    public class BM_GalleryController : Controller
    {
        // GET: BM_Gallery
        public ActionResult Index()
        {
            return View();
        }

        // GET: BM_Gallery/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BM_Gallery/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BM_Gallery/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BM_Gallery/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BM_Gallery/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BM_Gallery/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BM_Gallery/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}