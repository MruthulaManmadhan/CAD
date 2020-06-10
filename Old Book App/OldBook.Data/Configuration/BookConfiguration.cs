//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OldBook.Data.Model;


//namespace OldBook.Data.Configuration
//{
//    public class BookConfiguration : IEntityTypeConfiguration<Book>
//    {
//        public void Configure(EntityTypeBuilder<Book> builder)
//        {
//            //Map to table
//            builder.ToTable("User");



//            //Primary key
//            builder.HasKey(x => x.Id);



//            //properties
//            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
//            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
//            builder.Property(x => x.Edition).IsRequired();
//            builder.Property(x => x.Price).IsRequired();
//            builder.Property(x => x.Status).HasMaxLength(25);



//            //Relationship
//            builder.HasOne(x => x.Authors)
//                   .WithMany(x => x.Books)
//                   .OnDelete(DeleteBehavior.Restrict);
//        }
//    }







    //class BookConfiguration:DbContext
    //{
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Book>()
    //            .HasKey(c => c.Id);
    //        modelBuilder.Entity<Book>()
    //            .Property(c => c.Name).IsRequired();
    //        modelBuilder.Entity<Book>()
    //          .Property(c => c.Price).IsRequired();
    //    }
    //}
//}
