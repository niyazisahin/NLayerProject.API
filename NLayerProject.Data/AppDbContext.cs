using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NLayerProject.Core.Models;
using NLayerProject.Data.Configurations;
using NLayerProject.Data.Seed;
using System;
using System.Collections.Generic;

using System.Text;

namespace NLayerProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Veritabanı için özellikler yazılacak.
            modelBuilder.ApplyConfiguration(new ProductConfigurations());
            modelBuilder.ApplyConfiguration(new CategoryConfigurations());

            modelBuilder.ApplyConfiguration(new CategorySeed(new int[]{ 1,2}));
            modelBuilder.ApplyConfiguration(new ProductSeed(new int[]{ 1,2}));

            modelBuilder.ApplyConfiguration(new PersonConfigurations());

        }
    }
}
