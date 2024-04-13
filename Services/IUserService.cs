using webapi_tutorial.Models;

namespace webapi_tutorial.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        void AddUser(User user);
        bool UpdateUser(string id, User user);
        bool DeleteUserById(string id);
        User GetUserById(string id);
    }
}
