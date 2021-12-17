using System.Collections.Generic;
using festivalsql.Client.Services;
using festivalsql.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace festivalsql.Server.Controllers
{
    public class OneDayController : Controller
    {
        private readonly OneDayService _oneDayService = new();

        private readonly IEmailSender _emailSender;

        public OneDayController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [Route("api/endags")]
        [HttpGet]
        public IEnumerable<OneDay> GetOneDay()
        {
            return _oneDayService.GetAllOneDays();
        }

        [Route("api/endags/detail/{id}")]
        [HttpGet("detail/{id}")]
        public OneDay GetOneDayData(int id)
        {
            return _oneDayService.GetOneDayData(id);
        }

        [Route("api/endags/create")]
        [HttpPost]
        public void Post([FromBody] OneDay oneDay)
        {
            if (ModelState.IsValid)
            {
                var message = new Message(new string[] { oneDay.email }, "Billet til miljøfest", $"Hej {oneDay.navn}. Tak fordi du bestilte en endagsbillet til {oneDay.dato}.");
                _emailSender.SendEmail(message);
                _oneDayService.AddOneDay(oneDay);
            }
        }

        [Route("api/endags/edit")]
        [HttpPut("edit")]
        public void Put([FromBody] OneDay oneDay)
        {
            if (ModelState.IsValid)
            {
                _oneDayService.UpdateOneDay(oneDay);
            }
        }

        [Route("api/endags/delete{id}")]
        [HttpDelete("delete({id}")]
        public void DeleteOneDay(int id)
        {
            _oneDayService.DeleteOneDay(id);
        }
    }
}
