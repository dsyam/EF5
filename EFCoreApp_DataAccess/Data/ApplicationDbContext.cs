using EFCoreApp_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<BookDetail> BookDetails { get; set; }

        public DbSet<BookAuthor> BookAuthors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.Book_Id, ba.Author_Id}); // Composit key definition

            modelBuilder.Entity<Fluent_BookDetail>().HasKey(bd => bd.BookDetail_Id);
            modelBuilder.Entity<Fluent_BookDetail>().Property(bd => bd.NumberOfChapters).IsRequired();

            modelBuilder.Entity<Fluent_Author>().HasKey(a => a.Author_Id);
            modelBuilder.Entity<Fluent_Author>().Property(a => a.FirstName).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Property(a => a.LastName).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Ignore(a => a.FullName);

            modelBuilder.Entity<Fluent_Publisher>().HasKey(p => p.Publisher_Id);
            modelBuilder.Entity<Fluent_Publisher>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Fluent_Publisher>().Property(p => p.Location).IsRequired();

            modelBuilder.Entity<Fluent_Book>().HasKey(b => b.Book_Id);
            modelBuilder.Entity<Fluent_Book>().Property(b => b.Title).IsRequired();
            modelBuilder.Entity<Fluent_Book>().Property(b => b.ISBN).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<Fluent_Book>().Property(b => b.Price).IsRequired();
            modelBuilder.Entity<Fluent_Book>().Ignore(b => b.PriceRange);
        }

    }
}
