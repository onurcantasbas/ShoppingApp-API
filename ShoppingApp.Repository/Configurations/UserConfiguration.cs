using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Core.Models;
using ShoppingApp.Repository.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Repository.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasDiscriminator<string>("UserSegment")
        .HasValue<AdminUser>("Admin")
        .HasValue<BasicUser>("Basic");

            builder.HasKey(u => u.Id);
            
            builder.Property(u => u.Id).UseIdentityColumn();
           
            builder.Property(u => u.Name).IsRequired().HasMaxLength(20);
           
            builder.Property(u => u.Surname).IsRequired().HasMaxLength(20);
           
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(15);
           
            builder.Property(u => u.Password).IsRequired().HasMaxLength(15);
           
            builder.Property(u => u.Email).IsRequired();
            
            builder.HasMany(u => u.ShoppingLists).WithOne(s => s.User).HasForeignKey(s => s.UserId);
        }
    }
}
