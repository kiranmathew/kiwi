//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kiwi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EducationalInstitution
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