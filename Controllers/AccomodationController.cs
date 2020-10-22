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
        public ActionResult ListView()
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
                            path = Server.MapPath("~\\Content\\images\\Accomodation\\");

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
                    AccModel.AccomodationImage = acc.AccomodationImage;
                    AccModel.Description = acc.Description;
                    AccModel.Location = acc.Location;
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
            AccomodationViewModels acc = new AccomodationViewModels();
            var AccomodationEditData = db.Accomodations.Where(x => x.IsDelete == false&&x.AccomodationId==id).FirstOrDefault();
            acc.AccomodationTypeId = AccomodationEditData.AccomodationTypeId;
            acc.AccomodationName = AccomodationEditData.AccomodationName;
            acc.AccomodationLink = AccomodationEditData.AccomodationLink;
            acc.AccomodationPhone = AccomodationEditData.AccomodationPhone;
            acc.AccomodationAddress = AccomodationEditData.AccomodationAddress;
            acc.AccomodationImage = AccomodationEditData.AccomodationImage;
            acc.Description = AccomodationEditData.Description;
            acc.Location = AccomodationEditData.Location;
            acc.AccomodationDesciption = AccomodationEditData.AccomodationDesciption;
            acc.AccomodationEmail = AccomodationEditData.AccomodationEmail;
            acc.CreatedDate = AccomodationEditData.CreatedDate;
            acc.ModifiedDate = AccomodationEditData.ModifiedDate;
            acc.IsDelete = AccomodationEditData.IsDelete;
            acc.IsActive = AccomodationEditData.IsActive;
            acc.AccomType = db.AccomodationTypes.ToList();
            return View(acc);
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Edit(AccomodationViewModels acc,HttpPostedFileBase file)
        {
            Accomodation AccModel = new Accomodation();

            try
            {
                // TODO: Add update logic here
                if (file != null)
                {
                    string path = "";
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
                AccModel.AccomodationImage = acc.AccomodationImage;
                AccModel.Description = acc.Description;
                AccModel.Location = acc.Location;
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
                db.Entry(AccModel).State = EntityState.Modified;
                int status = db.SaveChanges();

                //    }
                //}

                return RedirectToAction("ListView");
            }
            catch
            {
                AccomodationViewModels accVM = new AccomodationViewModels();
                accVM.AccomType = db.AccomodationTypes.ToList();
                return View(accVM);
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
