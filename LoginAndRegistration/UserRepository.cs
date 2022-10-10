using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndRegistration
{
    public class UserRepository
    {
        public static List<User> users = new List<User>();

        public UserRepository()
        {
            users.Add(new User
            {
                FirstName = "Stjepan",
                LastName = "Petrović",
                Username = "Pipa",
                Password = "123456"
            });
        }

        public static User IsUser (string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    if (user.Password == password)
                    {
                        return user;
                    }
                }
            }
            return null;
        }

        public static void NewUser (User user)
        {
            users.Add(user);
        }
    }
}
