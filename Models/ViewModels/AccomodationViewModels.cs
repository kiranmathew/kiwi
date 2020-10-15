using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kiwi.Models.ViewModels
{
    public class AccomodationViewModels
    {
        public int AccomodationId { get; set; }
        public int AccomodationTypeId { get; set; }
        public string AccomodationTypeName { get; set; }
        public string AccomodationName { get; set; }
        public string AccomodationImage { get; set; }
        public string AccomodationAddress { get; set; }
        public string AccomodationPhone { get; set; }
        public string AccomodationEmail { get; set; }
        public string AccomodationDesciption { get; set; }
        public string AccomodationLink { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsActive { get; set; }


    }
}