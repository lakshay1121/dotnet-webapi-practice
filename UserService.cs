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

        public IEnumerable<User> GetUsers()
        {
            return _repository.GetUsers();
        }

        public void AddUser(User user)
        {
            _repository.AddUser(user);
        }

        public bool UpdateUser(string id, User user)
        {
            return _repository.UpdateUser(id, user);
        }

        public bool DeleteUserById(string id)
        {
            return _repository.DeleteUserById(id);
        }
        public User GetUserById(string id) { return _repository.GetUserById(id);}

    }
}
