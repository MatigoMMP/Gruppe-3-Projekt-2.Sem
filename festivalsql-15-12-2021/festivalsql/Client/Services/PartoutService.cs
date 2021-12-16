using System;
using Microsoft.EntityFrameworkCore;
using festivalsql.Shared.Models;
using System.Linq;
using System.Collections.Generic;

namespace festivalsql.Client.Services
{
    public class PartoutService
    {
        private readonly FestivalContext _partout = new();

        public IEnumerable<Partout> GetAllPartout()
        {
            try
            {
                return _partout.partout.ToList();
            }
            catch { throw; }
        }

        public void AddPartout(Partout partout)
        {
            try
            {
                _partout.partout.Add(partout);
                _partout.SaveChanges();
            }
            catch { throw; }
        }

        public void UpdatePartout(Partout partout)
        {
            try
            {
                _partout.Entry(partout).State = EntityState.Modified;
                _partout.SaveChanges();
            }
            catch { throw; }
        }

        public Partout GetPartoutData(int id)
        {
            try
            {
                return _partout.partout.First(partout => partout.partout_id == id);
            }
            catch { throw; }
        }

        public void DeletePartout(int id)
        {
            try
            {
                var entity = _partout.partout.First(partout => partout.partout_id == id);
                _partout.partout.Remove(entity);
                _partout.SaveChanges();
            }
            catch { throw; }
        }
    }
}
