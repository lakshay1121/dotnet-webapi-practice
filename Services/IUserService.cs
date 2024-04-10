using webapi_tutorial.Models;

namespace webapi_tutorial.Services
{
    public interface IUserService
    {
        IEnumerable<User> getUsers();
    }
}
