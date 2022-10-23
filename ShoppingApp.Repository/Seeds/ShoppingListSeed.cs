using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Repository.Seeds
{
    internal class ShoppingListSeed : IEntityTypeConfiguration<ShoppingList>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ShoppingList> builder)
        {
            builder.HasData(
                new ShoppingList
                {
                    Id = 1,
                    UserId = 1,
                    CreatedAt = DateTime.Now
                },
                new ShoppingList 
            
                {
                    Id = 2,
                    UserId = 1,
                    CreatedAt = DateTime.Now
                },
                new ShoppingList

                {
                    Id = 3,
                    UserId = 2,
                    CreatedAt = DateTime.Now
                }

            ) ;

        }
    }
}
