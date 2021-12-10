using System;
using Microsoft.EntityFrameworkCore;
using festivalsql.Shared.Models;
using System.Linq;
using System.Collections.Generic;

namespace festivalsql.Server.Data
{
    public class ShiftDbOperations
    {
        ShiftContext sc = new ShiftContext();

        public IEnumerable<Shift> GetAllShifts()
        {
            try
            {
                return sc.vagt.ToList();
            }
            catch { throw; }
        }

        public void AddShift(Shift shift)
        {
            try
            {
                sc.vagt.Add(shift);
                sc.SaveChanges();
            }
            catch { throw; }
        }

        public void UpdateShift(Shift shift)
        {
            try
            {
                sc.Entry(shift).State = EntityState.Modified;
                sc.SaveChanges();
            }
            catch { throw; }
        }

        public Shift GetShiftData(int id)
        {
            try
            {
                return sc.vagt.First(shift => shift.vagt_id == id);
            }
            catch { throw; }
        }

        public void DeleteShift(int id)
        {
            try
            {
                var entity = sc.vagt.First(shift => shift.vagt_id == id);
                sc.vagt.Remove(entity);
                sc.SaveChanges();
            }
            catch { throw; }
        }
    }
}
