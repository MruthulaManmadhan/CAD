//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OldBook.Data.Model;

//namespace OldBook.Data.Configuration
//{
//    public class AddressConfiguration : IEntityTypeConfiguration<Address>
//    {
//        public void Configure(EntityTypeBuilder<Address> builder)
//        {
//            //Map to table
//            builder.ToTable("User");



//            //Primary key
//            builder.HasKey(x => x.Id);



//            //properties
//            builder.Property(x => x.Id);
//            builder.Property(x => x.HouseName).IsRequired().HasMaxLength(100);
//            builder.Property(x => x.LandMark).IsRequired().HasMaxLength(100);
//            builder.Property(x => x.Street1).HasMaxLength(100);
//            builder.Property(x => x.Street2).HasMaxLength(100);
//            builder.Property(x => x.City).HasMaxLength(100);
//            builder.Property(x => x.Phone).IsRequired();


//            //Relationship
//            //builder.HasOne(x => x.User)
//            //       .WithMany(x => x.Addresses)
//            //       .HasForeignKey(x => x.UserIdFK)
//            //       .OnDelete(DeleteBehavior.Restrict);
//        }
//    }





    //class AddressConfiguration:DbContext
    //{
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Address>()
    //            .HasKey(c => c.Id);
    //        modelBuilder.Entity<Address>()
    //            .Property(c => c.Phone).IsRequired();
    //        modelBuilder.Entity<Address>()
    //            .Property(c => c.HouseNumber).IsRequired();
    //        modelBuilder.Entity<Address>()
    //            .Property(c => c.Street1).IsRequired();
    //    }
    //}
//}
