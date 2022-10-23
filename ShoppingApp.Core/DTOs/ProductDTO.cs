﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; } 
        public string Name { get; set; } = null!;
        public int Price { get; set; }
        public byte[]? Image { get; set; }
        public int CategoryId { get; set; }
    }
}
