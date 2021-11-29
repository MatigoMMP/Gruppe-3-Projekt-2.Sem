using miljoefestival.Shared.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace miljoefestival.Server.DataAccess
{
    public class DataAccessPostgreSqlProvider : IDataAccessProvider
    {
        private readonly DomainModelPostgreSqlContext _context;
        private readonly ILogger _logger;

        public DataAccessPostgreSqlProvider(DomainModelPostgreSqlContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("DataAccessPostgreSqlProvider");
        }

        public void AddUserRecord(User user)
        {
            _context.bruger.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUserRecord(User user)
        {
            _context.bruger.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUserRecord(int id)
        {
            var entity = _context.bruger.First(t => t.bruger_id == id);
            _context.bruger.Remove(entity);
            _context.SaveChanges();
        }

        public User GetUserSingleRecord(int id)
        {
            return _context.bruger.First(t => t.bruger_id == id);
        }

        public List<User> GetUserRecords()
        {
            return _context.bruger.ToList();
        }
    }
}
