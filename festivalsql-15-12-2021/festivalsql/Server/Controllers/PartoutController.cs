using System.Collections.Generic;
using festivalsql.Client.Services;
using festivalsql.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace festivalsql.Server.Controllers
{
    public class PartoutController : Controller
    {
        private readonly PartoutService _partoutService = new();

        private readonly IEmailSender _emailSender;

        public PartoutController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [Route("api/partout")]
        [HttpGet]
        public IEnumerable<Partout> GetPartout()
        {
            return _partoutService.GetAllPartout();
        }

        [Route("api/partout/detail/{id}")]
        [HttpGet("detail/{id}")]
        public Partout GetPartoutData(int id)
        {
            return _partoutService.GetPartoutData(id);
        }

        [Route("api/partout/create")]
        [HttpPost]
        public void Post([FromBody] Partout partout)
        {
            if (ModelState.IsValid)
            {
                var message = new Message(new string[] { partout.email }, "Billet til miljøfest", $"Hej {partout.navn}. Tak fordi du bestilte en partoutbillet");
                _emailSender.SendEmail(message);
                _partoutService.AddPartout(partout);
            }
        }

        [Route("api/partout/edit")]
        [HttpPut("edit")]
        public void Put([FromBody] Partout partout)
        {
            if (ModelState.IsValid)
            {
                _partoutService.UpdatePartout(partout);
            }
        }

        [Route("api/partout/delete{id}")]
        [HttpDelete("delete({id}")]
        public void DeletePartout(int id)
        {
            _partoutService.DeletePartout(id);
        }
    }
}
