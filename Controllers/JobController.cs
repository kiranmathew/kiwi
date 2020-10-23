using kiwi.Models;
using kiwi.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kiwi.Controllers
{
    public class JobController : Controller
    {
        kiwilandDbEntities db = new kiwilandDbEntities();

        // GET: Job
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateJob()
        {
            JobViewModel jobVM = new JobViewModel();
            jobVM.payTypeList = db.PayTypes.ToList();
            return View(jobVM);

        }
        [HttpPost]       
        public ActionResult CreateJob(JobViewModel jobVM, HttpPostedFileBase file)
        {
            try
            {
                // TODO: Add insert logic here

                Job JobModel = new Job();

                // bool Success = false;

                if (ModelState.IsValid)
                {

                    JobModel.JobTypeId = jobVM.PayTypeId;
                    JobModel.PayTypeId = jobVM.PayTypeId;
                    JobModel.JobTitile = jobVM.JobTitile;
                    JobModel.JobLocation = jobVM.JobLocation;
                    JobModel.JobDescription = jobVM.JobDescription;   
                    JobModel.JobPostDate = jobVM.JobPostDate;
                    JobModel.CreatedDate = DateTime.Now;
                    JobModel.ModifiedDate = DateTime.Now;
                    JobModel.IsDelete = false;                    
                    db.Jobs.Add(JobModel);
                    int status = db.SaveChanges();


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


    }
}