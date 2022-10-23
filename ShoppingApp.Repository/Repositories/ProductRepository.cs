using Microsoft.EntityFrameworkCore;
using ShoppingApp.Core.DTOs;
using ShoppingApp.Core.Models;
using ShoppingApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWithCategory()
        {
            return await _Context.Products.Include(x => x.Category).ToListAsync();
        }

        
    }
}
