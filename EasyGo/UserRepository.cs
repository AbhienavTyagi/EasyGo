using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EasyGo
{
    public static class UserRepository
    {
        public static User GetUser(string username, string password)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            }
        }

        public static bool RegisterUser(string username, string password)
        {
            using (var context = new ApplicationDbContext())
            {
                // Check if the user already exists
                var existingUser = context.Users.FirstOrDefault(u => u.Username == username);
                if (existingUser != null)
                {
                    return false; // User already exists
                }

                // Add new user
                var newUser = new User { Username = username, Password = password };
                context.Users.Add(newUser);
                context.SaveChanges();
                return true; // Registration successful
            }
        }
    }
}

