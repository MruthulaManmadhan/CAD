//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OldBook.Data.Model;


//namespace OldBook.Data.Configuration
//{
//    public class UserConfiguration : IEntityTypeConfiguration<User>
//    {
//        public void Configure(EntityTypeBuilder<User> builder)
//        {
//            //Map to table
//            builder.ToTable("User");



//            //Primary key
//            builder.HasKey(x => x.Id);



//            //properties
//            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
//            builder.Property(x => x.Type).IsRequired().HasMaxLength(100);
//            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);




//            //Relationship
//            builder.HasOne(x => x.Books)
//                   .WithMany(x => x.Authors)
//                   .OnDelete(DeleteBehavior.Restrict);
//        }
//    }






    //class UserConfiguration : DbContext
    //{
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<User>()
    //            .HasKey(c => c.Id);
    //        modelBuilder.Entity<User>()
    //            .Property(c => c.Name).IsRequired();
    //    }
    //}
//}
