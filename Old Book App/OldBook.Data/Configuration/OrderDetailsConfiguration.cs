//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OldBook.Data.Model;


//namespace OldBook.Data.Configuration
//{
//    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
//    {
//        public void Configure(EntityTypeBuilder<OrderDetails> builder)
//        {
//            //Map to table
//            builder.ToTable("User");



//            //Primary key
//            builder.HasKey(x => x.Id);



//            //properties
//            builder.Property(x => x.Id);
//            builder.Property(x => x.DateOfOrder).IsRequired();
//            builder.Property(x => x.Status).IsRequired().HasMaxLength(100);



//            //Relationship
//            builder.HasOne(x => x.Address)
//                   .WithMany(x => x.OrderDetails)
//                   .HasForeignKey(x => x.AddressIdFK)
//                   .OnDelete(DeleteBehavior.Restrict);

//            builder.HasOne(x => x.User)
//                   .WithMany(x => x.OrderDetails)
//                   .HasForeignKey(x => x.UserIdFK)
//                   .OnDelete(DeleteBehavior.Restrict);

//            builder.HasOne(x => x.Book)
//                   .WithMany(x => x.OrderDetails)
//                   .HasForeignKey(x => x.BookIdFK)
//                   .OnDelete(DeleteBehavior.Restrict);
//        }
//    }




    //class OrderDetailsConfiguration:DbContext
    //{
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<OrderDetails>()
    //            .HasKey(c => c.Id);
    //        modelBuilder.Entity<OrderDetails>()
    //            .Property(c => c.Books).IsRequired();
    //        modelBuilder.Entity<OrderDetails>()
    //            .Property(c => c.Address).IsRequired();
    //    }
    //}
//}
