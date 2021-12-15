using System;
using System.Linq;
using System.Collections.Generic;
using festivalsql.Client.Services;
using festivalsql.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace festivalsql.Server.Controllers
{
    public class ShiftController : Controller
    {
        private readonly ShiftService _shiftService = new();

        [Route("api/shift")]
        [HttpGet]
        public IEnumerable<Shift> GetShifts()
        {
            return _shiftService.GetAllShifts();
        }

        [Route("api/shift/detail/{id}")]
        [HttpGet("detail/{id}")]
        public Shift GetShiftData(int id)
        {
            return _shiftService.GetShiftData(id);
        }

        [Route("api/shift/create")]
        [HttpPost]
        public void Post([FromBody] Shift shift)
        {
            if (ModelState.IsValid)
            {
                _shiftService.AddShift(shift);
            }
        }

        [Route("api/shift/edit")]
        [HttpPut("edit")]
        public void Put([FromBody] Shift shift)
        {
            if (ModelState.IsValid)
            {
                _shiftService.UpdateShift(shift);
            }
        }

        [Route("api/shift/delete{id}")]
        [HttpDelete("delete({id}")]
        public void DeleteShift(int id)
        {
            _shiftService.DeleteShift(id);
        }
    }
}
