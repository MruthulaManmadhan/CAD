using Microsoft.EntityFrameworkCore;
//using OldBook.Data.Configuration;
using OldBook.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OldBook.Data
{
    public class SampleContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.ApplyConfiguration(new AddressConfiguration());
        //    modelBuilder.ApplyConfiguration(new BookConfiguration());
        //    modelBuilder.ApplyConfiguration(new CartConfiguration());
        //    modelBuilder.ApplyConfiguration(new OrderDetailsConfiguration());
        //    modelBuilder.ApplyConfiguration(new UserConfiguration());
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BookDB;Trusted_Connection=True;");
           
        }

    }
}
