﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_CRUD_TEST.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Ani_dbEntities : DbContext
    {
        public Ani_dbEntities()
            : base("name=Ani_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Empdt> Empdt { get; set; }
        public virtual DbSet<Img> Img { get; set; }
        public virtual DbSet<PhoneBook> PhoneBook { get; set; }
        public virtual DbSet<Sec_dt> Sec_dt { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Std_dt> Std_dt { get; set; }
        public virtual DbSet<StudentDetails> StudentDetails { get; set; }
        public virtual DbSet<User_dt> User_dt { get; set; }
        public virtual DbSet<UserRagistration> UserRagistration { get; set; }
    }
}
