using project.api.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.api.Repository.UserR
{
    public interface IUserRepository
    {
       
        IEnumerable<User> GetUsers();
        User GetUser(Guid userId);
        IEnumerable<User> GetUsers(IEnumerable<Guid> userIds);
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
        bool UserExists(User userId);
        IEnumerable<User> GetAllUsers(string mainCategory);
        bool Save();
    }
}
