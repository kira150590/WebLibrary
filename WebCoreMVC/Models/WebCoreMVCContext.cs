using System;
using Microsoft.EntityFrameworkCore;

namespace WebCoreMVC.Models
{
    public class WebCoreMVCContext : DbContext
    {
        public WebCoreMVCContext(DbContextOptions<WebCoreMVCContext> options) : base(options) { }

        public DbSet<Category> CategoriesList { get; set; }

        public DbSet<Book> BooksList { get; set; }

        public DbSet<User> UsersList { get; set; }

        public DbSet<Province> Provinces { get; set; }

        public DbSet<District> Districts { get; set; }
    }
}
