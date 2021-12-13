using System;
using Microsoft.EntityFrameworkCore;
using festivalsql.Shared.Models;
using System.Linq;
using System.Collections.Generic;

namespace festivalsql.Client.Services
{
    public class UserService
    {
        FestivalContext uc = new FestivalContext();

        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                return uc.bruger.ToList();
            }
            catch { throw; }
        }

        public void AddUser(User user)
        {
            try
            {
                uc.bruger.Add(user);
                uc.SaveChanges();
            }
            catch { throw; }
        }

        public void UpdateUser(User user)
        {
            try
            {
                uc.Entry(user).State = EntityState.Modified;
                uc.SaveChanges();
            }
            catch { throw; }
        }

        public User GetUserData(int id)
        {
            try
            {
                return uc.bruger.First(user => user.bruger_id == id);
            }
            catch { throw; }
        }

        public void DeleteUser(int id)
        {
            try
            {
                var entity = uc.bruger.First(user => user.bruger_id == id);
                uc.bruger.Remove(entity);
                uc.SaveChanges();
            }
            catch { throw; }
        }
    }
}
