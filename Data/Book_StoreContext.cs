using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Book_Store.Models;

namespace Book_Store.Data
{
    public class Book_StoreContext : DbContext
    {
        public Book_StoreContext (DbContextOptions<Book_StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Book_Store.Models.Author> Author { get; set; }

        public DbSet<Book_Store.Models.Book> Book { get; set; }

        public DbSet<Book_Store.Models.Publication> Publication { get; set; }

        public DbSet<Book_Store.Models.Publisher> Publisher { get; set; }
    }
}
