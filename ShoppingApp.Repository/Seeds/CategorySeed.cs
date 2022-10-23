using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingApp.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(

                new Category
                {
                    Id = 1,
                    Name = "Kırtasiye",
                    CreatedAt = DateTime.Now

                },
                new Category{
                    
                    Id = 2,
                    Name = "Elektronik",
                    CreatedAt = DateTime.Now

                }
                
            );
        }
    }
}
