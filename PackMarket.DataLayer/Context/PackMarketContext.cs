using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PackMarket.DataLayer.Entities;
using PackMarket.DataLayer.Entities.Entitieproduct;
using PackMarket.DataLayer.Entities.Entitieproduct.FaQ;

namespace PackMarket.DataLayer.Context
{
    public class PackMarketContext : DbContext
    {
        public PackMarketContext(DbContextOptions<PackMarketContext> options):base(options)
        {
            
        }
        public DbSet<MainSlider> MainSlider { get; set; }
        public DbSet<User> Users { get; set; }

        #region FaQ
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Question> Questions { get; set; }
        #endregion

        #region Product
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductGallery> ProductGalleries { get; set; }
        public DbSet<ProductGurantee> ProductGurantees { get; set; }
        public DbSet<PropertyName> PropertyNames { get; set; }
        public DbSet<PropertyName_Category> PropertyNameCategories { get; set; }
        public DbSet<PropertyValue> PropertyValues { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasOne(c => c.Categori)
                .WithMany()
                .HasForeignKey(c => c.SubCategory)
                .OnDelete(DeleteBehavior.NoAction); // 🚀 جلوگیری از cascade delete
        }

    }
}
