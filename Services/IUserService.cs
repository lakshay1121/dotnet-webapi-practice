using webapi_tutorial.Models;

namespace webapi_tutorial.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        void AddUser(User user);
        bool UpdateUser(string email, User user);
    }
}
