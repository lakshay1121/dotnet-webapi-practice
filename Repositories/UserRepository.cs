using webapi_tutorial.Models;

namespace webapi_tutorial.Repositories
{
    public class UserRepository
    {
        public IEnumerable<User> getUsers()
        {
            return new List<User>{

                new User{name="lakshay",email="lakshay@gmail.com",age=21},
                 new User{name="nishant",email="nishant@gmail.com",age=23},
                  new User{name="rahul",email="rahul@gmail.com",age=22},

            };
        }
    }
}
