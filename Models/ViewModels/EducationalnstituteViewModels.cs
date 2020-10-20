using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kiwi.Models.ViewModels
{
    public class EducationalnstituteViewModels
    {
        public int InstitutionId { get; set; }
        public string InstitutionName { get; set; }
        public string InstituionImage { get; set; }
        public string Email { get; set; }
        public Nullable<int> Phone { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsDelete { get; set; }


    }
}