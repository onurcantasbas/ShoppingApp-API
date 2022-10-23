using AutoMapper;
using ShoppingApp.Core.DTOs;
using ShoppingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<User,UserDTO>();
            CreateMap<ShoppingList, ShoppingListDTO>().ReverseMap();
            CreateMap<Product, ProductWithCategoryDTO>();
            
            
            
            CreateMap<UserUpdateDTO, User>().ReverseMap();

        }
    }
}
