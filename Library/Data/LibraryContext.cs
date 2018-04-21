using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Library.Models;

namespace Library.Data
{
    public class LibraryContext:DbContext
    {
        public LibraryContext() : base("name=DefaultConnection")
            {

            }

        public DbSet<Book>Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
    }
}