using ShoppingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core.DTOs
{
    public class ShoppingListDTO
    {
        public int UserId { get; set; }
        public ICollection<Product>? Products { get; set; }
        
    }
}
