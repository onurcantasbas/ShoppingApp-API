using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

                new Product
                {
                    CategoryId = 1,
                    Id = 1,
                    Name = "Kalem",
                    Price = 10,
                    CreatedAt = DateTime.Now
                },
                new Product
                {
                    CategoryId = 1,
                    Id = 2,
                    Name = "Kalemlik",
                    Price = 10,
                    CreatedAt = DateTime.Now
                },
                new Product
                {
                    CategoryId = 2,
                    Id = 3,
                    Name = "Bilgisayar",
                    Price = 1000,
                    CreatedAt = DateTime.Now
                }

            ) ;
        }
    }
}
