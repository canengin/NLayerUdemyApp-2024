using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Kalem 1", Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 1, Name = "Kalem 2", Price = 110, Stock = 25, CreatedDate = DateTime.Now },
                new Product { Id = 3, CategoryId = 1, Name = "Kalem 3", Price = 120, Stock = 30, CreatedDate = DateTime.Now },

                new Product { Id = 4, CategoryId = 2, Name = "Kitap 1", Price = 1000, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 5, CategoryId = 2, Name = "Kitap 2", Price = 1100, Stock = 25, CreatedDate = DateTime.Now },
                new Product { Id = 6, CategoryId = 2, Name = "Kitap 3", Price = 1200, Stock = 30, CreatedDate = DateTime.Now },

                new Product { Id = 7, CategoryId = 3, Name = "Defter 1", Price = 500, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 8, CategoryId = 3, Name = "Defter 2", Price = 510, Stock = 25, CreatedDate = DateTime.Now },
                new Product { Id = 9, CategoryId = 3, Name = "Defter 3", Price = 520, Stock = 30, CreatedDate = DateTime.Now }
                );
        }
    }
}
