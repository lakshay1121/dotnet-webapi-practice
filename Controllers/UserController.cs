using Microsoft.AspNetCore.Mvc;
using webapi_tutorial.Models;
using webapi_tutorial.Services;

namespace webapi_tutorial.Controllers
{

    [Route("/api/users")]
    [ApiController]
    public class UserController: ControllerBase
    {

        private readonly IUserService _userService;
        
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]

        public IEnumerable<User> getUsers()
        {
            return _userService.getUsers();
        }
    }
}
