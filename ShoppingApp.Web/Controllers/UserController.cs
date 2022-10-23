using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using ShoppingApp.Core.DTOs;
using ShoppingApp.Core.Models;
using ShoppingApp.Core.Services;

namespace ShoppingApp.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IService<User> _service;
        private readonly IMapper _mapper;
        

        public UserController(IService<User> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
            
        }


        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Login()
        {

            return View();

        }   
            
        [HttpPost]
        [AllowAnonymous]
        public  IActionResult Login(UserDTO userDTO)
        {
            User user =  _service.Where(x => x.UserName == userDTO.UserName && x.Password == userDTO.Password).FirstOrDefault();

            if (user != null)
            {
                HttpContext.Session.SetString("username", user.UserName);
                return RedirectToAction("UserDashBoard");

            }
            else { return View(); }
            
        }
        public IActionResult UserDashBoard()
        {
            if (HttpContext.Session.Get("UserId") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index","Product");
            }

        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UserUpdateDTO userUpdateDTO)
        {
            await _service.AddAsync(_mapper.Map<BasicUser>(userUpdateDTO));
            return View();
        }
    }
}
