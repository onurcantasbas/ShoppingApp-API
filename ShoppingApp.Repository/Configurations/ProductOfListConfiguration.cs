using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Repository.Configurations
{
    public class ProductOfListConfiguration : IEntityTypeConfiguration<ProductOfList>
    {
        public void Configure(EntityTypeBuilder<ProductOfList> builder)
        {

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.HasOne(p => p.ShoppingList)
                   .WithMany(s => s.Products)
                   .HasForeignKey(p => p.ShoppingListId);
            builder.HasOne(p => p.Product);
                   
            
        }
    }
    
}
