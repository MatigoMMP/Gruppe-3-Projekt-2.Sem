using System;
using Microsoft.EntityFrameworkCore;
using festivalsql.Shared.Models;
using System.Linq;
using System.Collections.Generic;

namespace festivalsql.Client.Services
{
    public class ShiftService
    {
        private readonly FestivalContext _shifts = new();

        public IEnumerable<Shift> GetAllShifts()
        {
            try
            {
                return _shifts.vagt.ToList();
            }
            catch { throw; }
        }

        public void AddShift(Shift shift)
        {
            try
            {
                _shifts.vagt.Add(shift);
                _shifts.SaveChanges();
            }
            catch { throw; }
        }

        public void UpdateShift(Shift shift)
        {
            try
            {
                _shifts.Entry(shift).State = EntityState.Modified;
                _shifts.SaveChanges();
            }
            catch { throw; }
        }

        public Shift GetShiftData(int id)
        {
            try
            {
                return _shifts.vagt.First(shift => shift.vagt_id == id);
            }
            catch { throw; }
        }

        public void DeleteShift(int id)
        {
            try
            {
                var entity = _shifts.vagt.First(shift => shift.vagt_id == id);
                _shifts.vagt.Remove(entity);
                _shifts.SaveChanges();
            }
            catch { throw; }
        }
    }
}
