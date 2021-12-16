using System;
using System.Linq;
using System.Collections.Generic;
using festivalsql.Client.Services;
using festivalsql.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace festivalsql.Server.Controllers
{
    public class EndagsController : Controller
    {
        private readonly EndagsService _endagsService = new();

        [Route("api/endags")]
        [HttpGet]
        public IEnumerable<Endags> GetEndags()
        {
            return _endagsService.GetAllEndags();
        }

        [Route("api/endags/detail/{id}")]
        [HttpGet("detail/{id}")]
        public Endags GetEndagsData(int id)
        {
            return _endagsService.GetEndagsData(id);
        }

        [Route("api/endags/create")]
        [HttpPost]
        public void Post([FromBody] Endags endags)
        {
            if (ModelState.IsValid)
            {
                _endagsService.AddEndags(endags);
            }
        }

        [Route("api/endags/edit")]
        [HttpPut("edit")]
        public void Put([FromBody] Endags endags)
        {
            if (ModelState.IsValid)
            {
                _endagsService.UpdateEndags(endags);
            }
        }

        [Route("api/endags/delete{id}")]
        [HttpDelete("delete({id}")]
        public void DeleteEndags(int id)
        {
            _endagsService.DeleteEndags(id);
        }
    }
}
