using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OAservice.Common;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OAservice.DAL
{
    public class SznetzoneContext:DbContext
    {
        public SznetzoneContext() : base("DefaultConnection") { }
        public DbSet<PersonBase> People { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<ClientInfo> Clients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<FailureReport> Reports { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();



            base.OnModelCreating(modelBuilder);
        }
    }
}