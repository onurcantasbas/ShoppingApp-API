using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShoppingApp.Core.Models
{
    public class ShoppingList : BaseEntity
    {
        public User User { get; set; } = null!;
        public int UserId { get; set; }
        [XmlArrayItem]
        public List<ProductOfList>? Products { get; set; }
    }
}
