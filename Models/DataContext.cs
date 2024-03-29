﻿
using DO_AN_PTUD.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace DO_AN_PTUD.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<AdminMenu> AdminMenus { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
