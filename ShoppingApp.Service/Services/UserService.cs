using AutoMapper;
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
    public class UserService : Service<User>, IUserService
    {
        private readonly IUserRepository _productrepository;
        private readonly IMapper _mapper;
        public UserService(IGenericRepository<User> repository, IUnitOfWork unitOfWork, IMapper mapper, IUserRepository productrepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _productrepository = productrepository;
        }
    }
}
