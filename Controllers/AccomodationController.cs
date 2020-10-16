using kiwi.Models;
using kiwi.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kiwi.Controllers
{
    public class AccomodationController : Controller
    {
        kiwilandDbEntities db = new kiwilandDbEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View(db.Accomodations.ToList());
        }

        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            AccomodationViewModels accVM = new AccomodationViewModels();
            accVM.AccomType = db.AccomodationTypes.ToList();
           
            return View(accVM);
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(AccomodationViewModels acc ,HttpPostedFileBase file)
        {
            try
            {
                // TODO: Add insert logic here

                Accomodation AccModel = new Accomodation();

               // bool Success = false;

                if (ModelState.IsValid)
                {
                    string path = "";
                    
                    if (file != null)
                    {
                            acc.AccomodationImage = file.FileName;
                            path = Server.MapPath("~\\Content\\Uploads\\");

                            file.SaveAs(path + file.FileName);

                            System.IO.DirectoryInfo di = new DirectoryInfo(path);

                            //foreach (FileInfo files in di.GetFiles())
                            //{
                            //    if (files.Name != acc.AccomodationImage)
                            //    {
                            //        files.Delete();
                            //    }

                            //}
                        
                    }

                    AccModel.AccomodationTypeId = acc.AccomodationTypeId;
                    AccModel.AccomodationName = acc.AccomodationName;
                    AccModel.AccomodationLink = acc.AccomodationLink;
                    AccModel.AccomodationPhone = acc.AccomodationPhone;
                    AccModel.AccomodationAddress = acc.AccomodationAddress;
                    AccModel.AccomodationImage = path;
                    AccModel.Description = acc.Description;
                    AccModel.AccomodationDesciption = acc.AccomodationDesciption;
                    AccModel.AccomodationEmail = acc.AccomodationEmail;
                    AccModel.CreatedDate = DateTime.Now;
                    AccModel.ModifiedDate = DateTime.Now;
                    AccModel.IsDelete = false;
                    AccModel.IsActive = false;


                    //using (db = new kiwilandDbEntities())
                    //{
                    //    using (DbContextTransaction trans = db.Database.BeginTransaction())
                    //    {
                            db.Accomodations.Add(AccModel);
                            int status = db.SaveChanges();

                    //    }
                    //}

                }
               return RedirectToAction("Index");
            }
            catch
            {
                AccomodationViewModels accVM = new AccomodationViewModels();
                accVM.AccomType = db.AccomodationTypes.ToList();
                return View(accVM);
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
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

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
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
