using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core.Models
{
    public class ProductOfList : BaseEntity
    {
        public ShoppingList ShoppingList { get; set; } = null!;
        public int ShoppingListId { get; set; }
        public Product Product { get; set; } =  null!;
        
    }
}
