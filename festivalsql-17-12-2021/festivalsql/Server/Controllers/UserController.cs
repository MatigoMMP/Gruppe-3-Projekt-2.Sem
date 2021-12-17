using System;
using System.Linq;
using System.Collections.Generic;
using festivalsql.Client.Services;
using festivalsql.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace festivalsql.Server.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService = new();

        [Route("api/user")]
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _userService.GetAllUsers();
        }

        [Route("api/user/detail/{id}")]
        [HttpGet("detail/{id}")]
        public User GetUserData(int id)
        {
            return _userService.GetUserData(id);
        }

        [Route("api/user/create")]
        [HttpPost]
        public void Post([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                _userService.AddUser(user);
            }
        }

        [Route("api/user/edit")]
        [HttpPut("edit")]
        public void Put([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                _userService.UpdateUser(user);
            }
        }

        [Route("api/user/delete{id}")]
        [HttpDelete("delete({id}")]
        public void DeleteUser(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}
