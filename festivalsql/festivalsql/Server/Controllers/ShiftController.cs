using System;
using System.Linq;
using System.Collections.Generic;
using festivalsql.Server.Data;
using festivalsql.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace festivalsql.Server.Controllers
{
    public class ShiftController : Controller
    {
        private ShiftDbOperations DbOperations = new ShiftDbOperations();

        [Route("api/shift")]
        [HttpGet]
        public IEnumerable<Shift> GetShifts()
        {
            return DbOperations.GetAllShifts();
        }

        [Route("api/shift/detail/{id}")]
        [HttpGet("detail/{id}")]
        public Shift GetShiftData(int id)
        {
            return DbOperations.GetShiftData(id);
        }

        [Route("api/shift/create")]
        [HttpPost]
        public void Post([FromBody] Shift shift)
        {
            if (ModelState.IsValid)
            {
                DbOperations.AddShift(shift);
            }
        }

        [Route("api/shift/edit")]
        [HttpPut("edit")]
        public void Put([FromBody] Shift shift)
        {
            if (ModelState.IsValid)
            {
                DbOperations.UpdateShift(shift);
            }
        }

        [Route("api/shift/delete{id}")]
        [HttpDelete("delete({id}")]
        public void DeleteShift(int id)
        {
            DbOperations.DeleteShift(id);
        }
    }
}
