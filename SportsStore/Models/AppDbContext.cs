﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    public class AppDbContext : DbContext {
    
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

         public DbSet<Product> Products { get; set; }
    }
}