using eshop.Entities;
using Microsoft.EntityFrameworkCore;

namespace eshop.Infrastructure.Data
{
    public class HalkEshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public HalkEshopDbContext(DbContextOptions<HalkEshopDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired()
                                                                .HasMaxLength(100);

            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(p => p.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Elektronik" },
                new Category { Id = 2, Name = "Kırtasiye" },
                new Category { Id = 3, Name = "Kadın/Erkek Giyim" }

            );



            modelBuilder.Entity<Product>().HasData(

                new Product { Id = 1, Name = "Dell Laptop", CategoryId = 1, Description = "Dell XPS 13", DiscountRate = 0.15, Price = 50000, Rating = 4.6, ImageUrl = "https://cdn.dsmcdn.com/ty603/product/media/images/20221119/20/218383878/627561411/1/1_org.jpg" },

                new Product { Id = 2, Name = "Beyaz Tahta", CategoryId = 2, Description = "150x35cm", DiscountRate = 0.25, Price = 500, Rating = 4.6, ImageUrl = "https://cdn.dsmcdn.com/ty603/product/media/images/20221119/20/218383878/627561411/1/1_org.jpg" },

                new Product { Id = 3, Name = "Tişört", CategoryId = 3, Description = "Kırmızı Tişört :)", DiscountRate = 0.15, Price = 350, Rating = 4.6, ImageUrl = "https://cdn.dsmcdn.com/ty603/product/media/images/20221119/20/218383878/627561411/1/1_org.jpg" }

            );

        }



    }
}
