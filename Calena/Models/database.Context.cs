﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calena.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CalenaEntities : DbContext
    {
        public CalenaEntities()
            : base("name=CalenaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<AboutService> AboutServices { get; set; }
        public virtual DbSet<BlogCat> BlogCats { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Catigory> Catigories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<PepleeSay> PepleeSays { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<Statistic> Statistics { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
