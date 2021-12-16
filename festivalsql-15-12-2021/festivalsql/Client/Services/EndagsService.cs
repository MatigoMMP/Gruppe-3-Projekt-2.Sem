using System;
using Microsoft.EntityFrameworkCore;
using festivalsql.Shared.Models;
using System.Linq;
using System.Collections.Generic;

namespace festivalsql.Client.Services
{
    public class EndagsService
    {
        private readonly FestivalContext _endags = new();

        public IEnumerable<Endags> GetAllEndags()
        {
            try
            {
                return _endags.endags.ToList();
            }
            catch { throw; }
        }

        public void AddEndags(Endags endags)
        {
            try
            {
                _endags.endags.Add(endags);
                _endags.SaveChanges();
            }
            catch { throw; }
        }

        public void UpdateEndags(Endags endags)
        {
            try
            {
                _endags.Entry(endags).State = EntityState.Modified;
                _endags.SaveChanges();
            }
            catch { throw; }
        }

        public Endags GetEndagsData(int id)
        {
            try
            {
                return _endags.endags.First(endags => endags.endags_id == id);
            }
            catch { throw; }
        }

        public void DeleteEndags(int id)
        {
            try
            {
                var entity = _endags.endags.First(endags => endags.endags_id == id);
                _endags.endags.Remove(entity);
                _endags.SaveChanges();
            }
            catch { throw; }
        }
    }
}
