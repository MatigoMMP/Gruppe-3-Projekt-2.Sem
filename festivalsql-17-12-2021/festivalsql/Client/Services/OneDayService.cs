using Microsoft.EntityFrameworkCore;
using festivalsql.Shared.Models;
using System.Linq;
using System.Collections.Generic;

namespace festivalsql.Client.Services
{
    public class OneDayService : TicketService
    {
        private readonly FestivalContext _oneDay = new();

        public OneDayService(EmailConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
        }

        public OneDayService()
        {

        }

        public IEnumerable<OneDay> GetAllOneDays()
        {
            try
            {
                return _oneDay.endags.ToList();
            }
            catch { throw; }
        }

        public void AddOneDay(OneDay oneDay)
        {
            try
            {
                _oneDay.endags.Add(oneDay);
                _oneDay.SaveChanges();
            }
            catch { throw; }
        }

        public void UpdateOneDay(OneDay oneDay)
        {
            try
            {
                _oneDay.Entry(oneDay).State = EntityState.Modified;
                _oneDay.SaveChanges();
            }
            catch { throw; }
        }

        public OneDay GetOneDayData(int id)
        {
            try
            {
                return _oneDay.endags.First(oneDay => oneDay.endags_id == id);
            }
            catch { throw; }
        }

        public void DeleteOneDay(int id)
        {
            try
            {
                var entity = _oneDay.endags.First(oneDay => oneDay.endags_id == id);
                _oneDay.endags.Remove(entity);
                _oneDay.SaveChanges();
            }
            catch { throw; }
        }
    }
}
