using System.Collections.Generic;

namespace miljoefestival.Shared.Models
{
    public interface IDataAccessProvider
    {
        void AddUserRecord(User user);
        void UpdateUserRecord(User user);
        void DeleteUserRecord(int id);
        User GetUserSingleRecord(int id);
        List<User> GetUserRecords();
    }
}
