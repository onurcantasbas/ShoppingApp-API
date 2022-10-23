using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int Price { get; set; }
        public byte[]? Image { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
