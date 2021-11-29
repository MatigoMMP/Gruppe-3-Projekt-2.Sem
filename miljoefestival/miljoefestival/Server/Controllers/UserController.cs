using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miljoefestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace miljoefestival.Server.Controllers
{
    public class UserController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public UserController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        [Route("api/User/Get")]
        public IEnumerable<User> Get()
        {
            return _dataAccessProvider.GetUserRecords();
        }

        [HttpPost]
        [Route("api/User/Create")]
        public void Create([FromBody]User user)
        {
            if (ModelState.IsValid)
            {
                /*Guid obj = Guid.NewGuid();
                user.username = obj.ToString();*/
                _dataAccessProvider.AddUserRecord(user);
            }
        }

        [HttpGet]
        [Route("api/User/Details/{Id}")]
        public User Details(int id)
        {
            return _dataAccessProvider.GetUserSingleRecord(id);
        }

        [HttpPut]
        [Route("api/User/Edit")]
        public void Edit([FromBody]User user)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateUserRecord(user);
            }
        }

        [HttpDelete]
        [Route("api/User/Delete/{Id}")]
        public void DeleteConfirmed(int id)
        {
            _dataAccessProvider.DeleteUserRecord(id);
        }
    }
}
