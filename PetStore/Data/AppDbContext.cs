using Microsoft.EntityFrameworkCore;
using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category_Toy>().HasKey(am => new
            {
                am.CategoryId,
                am.ToyId
            });

            modelBuilder.Entity<Category_Toy>().HasOne(m => m.Toy).WithMany(am => am.Categories_Toys).HasForeignKey(m => m.ToyId);
            modelBuilder.Entity<Category_Toy>().HasOne(m => m.Category).WithMany(am => am.Categories_Toys).HasForeignKey(m => m.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<Category_Toy> Categories_Toys { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
