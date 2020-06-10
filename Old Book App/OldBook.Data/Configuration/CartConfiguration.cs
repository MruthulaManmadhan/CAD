//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OldBook.Data.Model;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace OldBook.Data.Configuration
//{
//    public class CartConfiguration : IEntityTypeConfiguration<Cart>
//    {
//        public void Configure(EntityTypeBuilder<Cart> builder)
//        {
//            //Map to table
//            builder.ToTable("User");



//            //Primary key
//            builder.HasKey(x => x.Id);



//            //properties
//            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
//            builder.Property(x => x.TotalPrice).IsRequired().HasMaxLength(100);
//            builder.Property(x => x.Status).IsRequired();



//            //Relationship
//            builder.HasOne(x => x.Book)
//                   .WithMany(x => x.Carts)
//                   .HasForeignKey(x => x.BookIdFK)
//                   .OnDelete(DeleteBehavior.Restrict);
//            builder.HasOne(x => x.User)
//                   .WithMany(x => x.Carts)
//                   .HasForeignKey(x => x.UserIdFK)
//                   .OnDelete(DeleteBehavior.Restrict);
//        }
//    }





    //class CartConfiguration:DbContext
    //{
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Cart>()
    //            .HasKey(c => c.Id);
    //        modelBuilder.Entity<Cart>()
    //            .Property(c => c.Books).IsRequired();
    //    }
    //}
//}
