using KhalilsOutlet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

namespace KhalilsOutlet.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //parameter represents configuration options for the database context.
        //base(options)) is called to initialize the database context

        {

        }
        
        
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser>ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Nike V2k Run Sneaker 1",
                    Brand = "Nike",
                    Category = "Men",
                    price = 160,
                    Description = "The Nike V2K Run Sneaker is a blend of nostalgic style and modern performance," +
                "ideal for those looking for a sneaker that performs well in both casual and athletic settings.",
                    ImageFileName = "Nike V2k Run Sneaker 1.jpg",
                    CreatedAt = DateTime.Now,
                },
                 new Product
                 {
                     Id = 2,
                     Name = "Nike Air Foamposite Pro Forest",
                     Brand = "Nike",
                     Category = "Men",
                     price = 420,
                     Description = "The Nike Air Foamposite Pro Forest is a fusion of style and functionality. Its bold design, durable construction," +
                     "and advanced cushioning make it a favorite among sneaker collectors and athletes..",
                     ImageFileName = "Nike Air Foamposite Pro Forest.jpg",
                     CreatedAt = DateTime.Now,
                 },
                  new Product
                  {
                      Id = 3,
                      Name = "Adidas Terrex",
                      Brand = "Adidas",
                      Category = "Men",
                      price = 335,
                      Description = "The Adidas Terrex line is highly regarded for its performance and reliability in outdoor settings.",
                      ImageFileName = "Adidas Terrex.jpg",
                      CreatedAt = DateTime.Now,
                  },
                   new Product
                   {
                       Id = 4,
                       Name = "Adidas Gazelle Indoor",
                       Brand = "Adidas",
                       Category = "Women",
                       price = 115,
                       Description = "The Adidas Gazelle Indoor is a blend of classic style and modern functionality. ",
                       ImageFileName = "Adidas Gazelle Indoor.jpg",
                       CreatedAt = DateTime.Now,
                   },
                   new Product
                   {
                       Id = 5,
                       Name = "Reebok BB4600",
                       Brand = "Reebok",
                       Category = "Men",
                       price = 225,
                       Description = "The Reebok BB4600 is a standout shoe that combines the best of old-school basketball aesthetics with modern comfort and durability.",
                       ImageFileName = "Reebok BB4600.jpg",
                       CreatedAt = DateTime.Now,
                   }
                );
        }
    }
}
