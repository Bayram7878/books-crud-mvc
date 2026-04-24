using books_crud_mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace books_crud_mvc.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}