using System.Collections.Generic;
using webapi_tutorial.Models;

namespace webapi_tutorial.Repositories
{
    public class UserRepository
    {
        private static readonly List<User> users = new List<User>
        {
            new User{id="1", name = "John Doe", age = 30, email = "john@gmail.com"},
            new User{id="2", name = "Mark", age = 25, email = "mark@gmail.com"}
        };
        private int _nextId = 1;

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public void AddUser(User user)
        {

            if (user != null)
            {
                users.Add(user);
                
            }
            else
            {
                throw new ArgumentNullException(nameof(user), "User object cannot be null.");
            }
        }
        public bool UpdateUser(string email, User updatedUser)
        {
            var existingUser = users.Find(u => u.email == email);
            if (existingUser != null)
            {
                existingUser.name = updatedUser.name;
                existingUser.email = updatedUser.email;
                existingUser.age = updatedUser.age;
                return true;
            }
            return false;
        }
    }
}
