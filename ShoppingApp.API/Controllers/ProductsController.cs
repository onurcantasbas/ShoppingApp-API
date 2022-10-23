using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Core.DTOs;
using ShoppingApp.Core.Models;
using ShoppingApp.Core.Services;

namespace ShoppingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _service;
        public ProductsController(IMapper mapper, IService<Product> service)
        {
            _mapper = mapper;
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();

            var productsDTO = _mapper.Map<List<ProductDTO>>(products.ToList());

            return CreateActionResult(CustomResponseDTO<List<ProductDTO>>.Success(200, productsDTO));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);

            var productDTO = _mapper.Map<ProductDTO>(product);

            return CreateActionResult(CustomResponseDTO<ProductDTO>.Success(200, productDTO));

        }
        [HttpPost]
        public async Task<IActionResult> Save(ProductDTO productDTO)
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(productDTO));

            //var productDTO = _mapper.Map<ProductDTO>(productDTO);

            return CreateActionResult(CustomResponseDTO<ProductDTO>.Success(200,productDTO));

        }
        [HttpPut]
        public async Task<IActionResult> Update(ProductDTO productDTO)
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDTO));

            return CreateActionResult(CustomResponseDTO<NoContentDTO>.Success(204));

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(product);

            return CreateActionResult(CustomResponseDTO<NoContentDTO>.Success(204));
        }

    }
}
