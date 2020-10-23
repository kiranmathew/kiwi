using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kiwi.Models.ViewModels
{
    public class JobViewModel
    {
        public int JobId { get; set; }
        public int JobTypeId { get; set; }
        public int PayTypeId { get; set; }
        public string JobTitile { get; set; }
        public string JobDescription { get; set; }
        public string JobLocation { get; set; }
        public Nullable<System.DateTime> JobPostDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsDelete { get; set; }


       
        public string JobTypeName { get; set; }

        public string PayType { get; set; }

        public List<JobType> jobTypeList { get; set; }
        public List<PayType> payTypeList { get; set; }
    }
}