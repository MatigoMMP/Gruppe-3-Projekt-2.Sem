using System.Collections.Generic;
using festivalsql.Client.Services;
using festivalsql.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace festivalsql.Server.Controllers
{
    public class EndagsController : Controller
    {
        private readonly EndagsService _endagsService = new();

        private readonly IEmailSender _emailSender;

        public EndagsController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

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
                var message = new Message(new string[] { endags.email }, "Billet til miljøfest", $"Hej {endags.navn}. Tak fordi du bestilte en endagsbillet til {endags.dato}.");
                _emailSender.SendEmail(message);
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
