﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kiwilandDbEntities : DbContext
    {
        public kiwilandDbEntities()
            : base("name=kiwilandDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccomodationType> AccomodationTypes { get; set; }
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolePrivilege> RolePrivileges { get; set; }
        public virtual DbSet<Accomodation> Accomodations { get; set; }
        public virtual DbSet<EducationalInstitution> EducationalInstitutions { get; set; }
        public virtual DbSet<Attraction> Attractions { get; set; }
        public virtual DbSet<Community> Communities { get; set; }
        public virtual DbSet<AboutU> AboutUs { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<PayType> PayTypes { get; set; }
    }
}
