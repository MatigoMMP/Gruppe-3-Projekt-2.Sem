using System;
using Microsoft.EntityFrameworkCore;
using festivalsql.Shared.Models;
using System.Linq;
using System.Collections.Generic;

namespace festivalsql.Client.Services
{
    public class UserService
    {
        private readonly FestivalContext _users = new();

        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                return _users.bruger.ToList();
            }
            catch { throw; }
        }

        public void AddUser(User user)
        {
            try
            {
                _users.bruger.Add(user);
                _users.SaveChanges();
            }
            catch { throw; }
        }

        public void UpdateUser(User user)
        {
            try
            {
                _users.Entry(user).State = EntityState.Modified;
                _users.SaveChanges();
            }
            catch { throw; }
        }

        public User GetUserData(int id)
        {
            try
            {
                return _users.bruger.First(user => user.bruger_id == id);
            }
            catch { throw; }
        }

        public void DeleteUser(int id)
        {
            try
            {
                var entity = _users.bruger.First(user => user.bruger_id == id);
                _users.bruger.Remove(entity);
                _users.SaveChanges();
            }
            catch { throw; }
        }
    }
}
