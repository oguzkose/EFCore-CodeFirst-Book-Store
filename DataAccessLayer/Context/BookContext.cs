using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Context
{
    public class BookContext : DbContext
    {
        #region CONNECTİON STRİNG
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies() 
                .UseSqlServer("Server=.;Database=BookDb;uid=sa;pwd=123");
            base.OnConfiguring(optionsBuilder);
        }
        #endregion

        #region ONMODELCREATİNG-BookAuthor relations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   //Composit Key 
            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });

            //BookAuthor - Author Relation
            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.BookId);

            //BookAuthor - Author Relation
            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(ba => ba.AuthorId);
        }
        #endregion

        #region DbSet's
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; } 
        #endregion
    }
}
