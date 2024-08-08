using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        /* public static bool RegisterUser(string username, string password, string firstName, string lastName, string city, string postalCode, string mobileNumber)
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
                 var newUser = new User
                 {
                     Username = username,
                     Password = password,
                     FirstName = firstName,
                     LastName = lastName,
                     City = city,
                     PostalCode = postalCode,
                     MobileNumber = mobileNumber
                 };
                 context.Users.Add(newUser);
                 context.SaveChanges();
                 return true; // Registration successful
             }*/

        public static bool RegisterUser(string username, string password, string firstName, string lastName, string city, string postalCode, string mobileNumber)
            {
                string connectionString = "Server=LOCALHOST\\SQLSERVER19;Database=BikeShopDB;User Id=sa;Password=Pranav09*;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Users (Username, Password, FirstName, LastName, City, PostalCode, MobileNumber) " +
                                   "VALUES (@Username, @Password, @FirstName, @LastName, @City, @PostalCode, @MobileNumber);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@PostalCode", postalCode);
                        command.Parameters.AddWithValue("@MobileNumber", mobileNumber);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                    catch (SqlException ex)
                    {
                        // Handle exception (e.g., log it)
                        Console.WriteLine($"SQL Error: {ex.Message}");
                        return false;
                    }
                }
                }
            
        }
    }
}

