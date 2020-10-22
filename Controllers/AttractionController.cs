using kiwi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
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
        public ActionResult Details(int id)
        {
            return View(db.Attractions.Find(id));
        }

        // GET: Attraction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attraction/Create
        [HttpPost]
        public ActionResult Create(Attraction Att,HttpPostedFileBase file)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    string path = "";

                    if (file != null)
                    {
                        Att.AttractionImage = file.FileName;
                        path = Server.MapPath("~\\Content\\images\\Attraction\\");
                        file.SaveAs(path + file.FileName);
                        System.IO.DirectoryInfo di = new DirectoryInfo(path);
                    }
                    else
                    {
                        Att.AttractionImage = "";
                    }
                    // TODO: Add insert logic here
                    Att.CreatedDate = DateTime.Now;
                    Att.ModifiedDate = DateTime.Now;
                    Att.IsDelete = false;


                    db.Attractions.Add(Att);
                    int status = db.SaveChanges();
                }                
                   return RedirectToAction("Index");
                          
                
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
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
