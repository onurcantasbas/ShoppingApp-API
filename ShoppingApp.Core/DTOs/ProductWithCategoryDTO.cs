﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core.DTOs
{
    public class ProductWithCategoryDTO : ProductDTO
    {
        public CategoryDTO Category { get; set; }
    }
}