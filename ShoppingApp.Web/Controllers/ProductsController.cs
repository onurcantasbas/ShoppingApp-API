using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using ShoppingApp.Core.DTOs;
using ShoppingApp.Core.Models;
using ShoppingApp.Core.Services;

namespace ShoppingApp.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _service;
        private readonly IMapper _mapper;
        

        public ProductsController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;        
        }

        public async  Task<IActionResult> Index()
        {
            var products = await _service.GetProductsWithCategory();
            var productsDTO = _mapper.Map<List<ProductDTO>>(products.ToList());
           
            return View( products);
        }
    }
}
