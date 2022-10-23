using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingApp.Repository.Seeds
{
    internal class AdminUserSeed : IEntityTypeConfiguration<AdminUser>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdminUser> builder)
        {
            builder.HasData(
               new AdminUser
               {

                   Id = 1,
                   Name = "Onur",
                   Surname = "Tasbas",
                   UserName = "healpls",
                   Password = "123a4b",
                   Email = "onurcan@gmail.com",
                   CreatedAt = DateTime.Now
               },
               new AdminUser
               {

                   Id = 2,
                   Name = "Ahmet",
                   Surname = "asdad",
                   UserName = "healpls11",
                   Password = "123a4b222",
                   Email = "Ahaan@gmail.com",
                   CreatedAt = DateTime.Now
               },
               new AdminUser
               {

                   Id = 3,
                   Name = "Ahmet11",
                   Surname = "DKAAKA",
                   UserName = "hls11",
                   Password = "14b222",
                   Email = "n@gmail.com",
                   CreatedAt = DateTime.Now
               }






               );
        }
    }
    
}
