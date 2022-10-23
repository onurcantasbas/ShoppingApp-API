using AutoMapper;
using ShoppingApp.Core.DTOs;
using ShoppingApp.Core.Models;
using ShoppingApp.Core.Repositories;
using ShoppingApp.Core.Services;
using ShoppingApp.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Service.Services
{
    public class ShoppingListService : Service<ShoppingList>, IShoppingListService
    {
        private readonly IShoppingListRepository _shoppingListRepository;
        private readonly IMapper _mapper;
        public ShoppingListService(IGenericRepository<ShoppingList> repository, IUnitOfWork unitOfWork, IShoppingListRepository shoppingListRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _shoppingListRepository = shoppingListRepository;
            _mapper = mapper;
        }

        public  List<ShoppingListDTO> GetShoppingListByUserId(int userId)
        {
            List<ShoppingList> shoppingLists = _shoppingListRepository.Where(x => x.UserId == userId).ToList();
            List<ShoppingListDTO> shoppingListDTOs = _mapper.Map<List<ShoppingListDTO>>(shoppingLists);
            return shoppingListDTOs;
        }

        
        
    }
}
