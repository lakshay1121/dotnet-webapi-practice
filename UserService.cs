using webapi_tutorial.Models;
using webapi_tutorial.Repositories;
using webapi_tutorial.Services;

namespace webapi_tutorial
{
    public class UserService : IUserService
    {

        private readonly UserRepository _repository;

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<User> getUsers()
        {
            return _repository.getUsers();
        }

    }
}
