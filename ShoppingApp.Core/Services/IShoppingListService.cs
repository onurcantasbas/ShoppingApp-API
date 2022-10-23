using ShoppingApp.Core.DTOs;
using ShoppingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core.Services
{
    public interface IShoppingListService : IService<ShoppingList>
    {
        List<ShoppingListDTO> GetShoppingListByUserId(int userId);

        
    }
}
