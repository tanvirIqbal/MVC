using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DAL
{
    public class CustomerDAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}