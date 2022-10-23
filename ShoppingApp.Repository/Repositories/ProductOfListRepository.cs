using ShoppingApp.Core.Models;
using ShoppingApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Repository.Repositories
{
    internal class ProductOfListRepository : GenericRepository<ProductOfList>, IProductOfListRepository
    {
        public ProductOfListRepository(AppDbContext context) : base(context)
        {
        }
    }
}
