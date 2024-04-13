using Microsoft.AspNetCore.Mvc;
using webapi_tutorial.Models;
using webapi_tutorial.Services;
using System.Collections.Generic;

namespace webapi_tutorial.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _userService.GetUsers();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userService.AddUser(user);
            return CreatedAtAction(nameof(GetUsers), new { id = user.email }, user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(string id, User user)
        {
            var result = _userService.UpdateUser(id, user);
            if (result)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(string id)
        {
            var result = _userService.DeleteUserById(id);
            if (result)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(string id)
        {
            var user = _userService.GetUserById(id);
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
