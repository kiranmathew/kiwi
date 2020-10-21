using kiwi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kiwi.Controllers
{
    public class AttractionController : Controller
    {
        kiwilandDbEntities db = new kiwilandDbEntities();
        // GET: Attraction
        public ActionResult Index()
        {
            return View(db.Attractions.ToList());
        }

        // GET: Attraction/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: Attraction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attraction/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Attraction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Attraction/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Attraction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Attraction/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
