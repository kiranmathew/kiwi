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
    
    public partial class Accomodation
    {
        public int AccomodationId { get; set; }
        public int AccomodationTypeId { get; set; }
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
        public string Location { get; set; }
    }
}
