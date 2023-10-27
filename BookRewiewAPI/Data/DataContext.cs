using BookRewiewAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookRewiewAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookOwner> BookOwners { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Review> Rewiews { get; set; }
        public DbSet<Reviewer> Rewiewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategory>()
                .HasKey(pc => new { pc.BookId, pc.CategoryId });
            modelBuilder.Entity<BookCategory>()
                .HasOne(p => p.Book)
                .WithMany(pc => pc.BookCategories)
                .HasForeignKey(p => p.BookId);
            modelBuilder.Entity<BookCategory>()
                .HasOne(p => p.Category)
                .WithMany(pc => pc.BookCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<BookOwner>()
                .HasKey(po => new { po.BookId, po.OwnerId });
            modelBuilder.Entity<BookOwner>()
                .HasOne(p => p.Book)
                .WithMany(pc => pc.BookOwners)
                .HasForeignKey(p => p.BookId);
            modelBuilder.Entity<BookOwner>()
                .HasOne(p => p.Owner)
                .WithMany(pc => pc.BookOwners)
                .HasForeignKey(c => c.OwnerId);
        }
    }
}
