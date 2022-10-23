using AutoMapper;
using ShoppingApp.Core.DTOs;
using ShoppingApp.Core.Models;
using ShoppingApp.Core.Repositories;
using ShoppingApp.Core.Services;
using ShoppingApp.Core.UnitOfWorks;

namespace ShoppingApp.Service.Services
{
    public class ProductService : Service<Product> , IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }



        async Task<List<ProductWithCategoryDTO>> IProductService.GetProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWithCategory();
            var productsDTO = _mapper.Map<List<ProductWithCategoryDTO>>(products);
            return productsDTO;
        }
    }
}
