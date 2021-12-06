using System;
using System.Linq;
using System.Collections.Generic;
using festivalsql.Server.Data;
using festivalsql.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace festivalsql.Server.Controllers
{
    public class UserController : Controller
    {
        private UserDbOperations DbOperations = new UserDbOperations();

        [Route("api/user")]
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return DbOperations.GetAllUsers();
        }

        [Route("api/user/detail/{id}")]
        [HttpGet("detail/{id}")]
        public User GetUserData(int id)
        {
            return DbOperations.GetUserData(id);
        }

        [Route("api/user/create")]
        [HttpPost]
        public void Post([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                DbOperations.AddUser(user);
            }
        }

        [Route("api/user/edit")]
        [HttpPut("edit")]
        public void Put([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                DbOperations.UpdateUser(user);
            }
        }

        [Route("api/user/delete{id}")]
        [HttpDelete("delete({id}")]
        public void DeleteUser(int id)
        {
            DbOperations.DeleteUser(id);
        }
    }
}
