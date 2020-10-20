using kiwi.Models;
using kiwi.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kiwi.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        kiwilandDbEntities db = new kiwilandDbEntities();
        public ActionResult Index()
        {
            return View(db.EducationalInstitutions.ToList());
        }

        // GET: Education/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Education/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Education/Create
        [HttpPost]
        public ActionResult Create(EducationalnstituteViewModels EduVM, HttpPostedFileBase file)
        {
             EducationalInstitution EduModel = new EducationalInstitution();
            // TODO: Add insert logic here
            try
            {
                if (ModelState.IsValid)
                {
                    string path = "";

                    if (file != null)
                    {
                        EduModel.InstituionImage = file.FileName;
                        path = Server.MapPath("~\\Content\\images\\Education");

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
                    else
                    {

                    }

                    EduModel.InstitutionName = EduVM.InstitutionName;
                    
                    EduModel.Location = EduVM.Location;
                    EduModel.Address = EduVM.Address;
                    EduModel.Email = "";
                    EduModel.Phone = 123456;
                    EduModel.Link = EduVM.Link;
                    EduModel.Description = EduVM.Description;
                    EduModel.CreatedDate = DateTime.Now;
                    EduModel.ModifiedDate = DateTime.Now;
                    EduModel.IsDelete = false;



                    //using (db = new kiwilandDbEntities())
                    //{
                    //    using (DbContextTransaction trans = db.Database.BeginTransaction())
                    //    {
                    db.EducationalInstitutions.Add(EduModel);
                    int status = db.SaveChanges();

                    //    }
                    //}

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

        // GET: Education/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Education/Edit/5
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

        // GET: Education/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Education/Delete/5
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
