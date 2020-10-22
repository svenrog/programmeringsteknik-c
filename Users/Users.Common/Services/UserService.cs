using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using Users.Common.Models;

namespace Users.Common.Services
{
    public class UserService : IUserService
    {

        static List<User> listOfUsers = User.ListOfUsers();

        public static string LoginUser(string userInput, string userPassword)
        {

            foreach (var item in listOfUsers)
            {
                if (item.Email == userInput)
                {
                    Console.WriteLine("There is an email!");

                    //Måste koppla password till något, ID?
                    //if (item.Password == password)
                    //{
                    //    Console.WriteLine("Successfully logged in!");
                    //}
                    return "Successfully Logged In!";
                }
            }


        }



        public static void AddUser(Guid id, string name, string email, string phone, bool subNewsLetter)
        {
            foreach (User item in listOfUsers)
            {
                if(item.Email == email) { Console.WriteLine($"There is already an email called {email}");}

            }

            (listOfUsers.Add(new User() { Id = id, Name = name, Email = email, Phone = phone, SubscribeToNewsletter = subNewsLetter });

        }










        /// <summary>
        /// Gets a user by email
        /// </summary>
        /// <param name="email">User email (has to be unique)</param>
        /// <returns>The user object</returns>
        /// <exception cref="ArgumentOutOfRangeException">If user isn't found</exception>
        public IUser Get(string email)
        {
            foreach (var item in listOfUsers)
            {
                if (item.Email == email)
                {
                    Console.WriteLine($"Kuuung din mail: {email} finns i databasen, fortsätt :).");
                }
            }

            throw new ArgumentOutOfRangeException($"{email} was not found in database");
        }

        /// <summary>
        /// Gets a user by id
        /// </summary>
        /// <param name="userId">The users internal id</param>
        /// <returns>The user object</returns>
        /// <exception cref="ArgumentOutOfRangeException">If user isn't found</exception>
        public IUser Get(Guid userId)
        {
            foreach (var item in listOfUsers)
            {
                if (item.Id == userId)
                {
                    Console.WriteLine($"Kuuung din mail: {userId} finns i databasen, fortsätt :).");
                }
            }

            throw new ArgumentOutOfRangeException($"{userId} was not found in database");
        }

        /// <summary>
        /// Authenticates and logs a user in, normally this method returns a token or sets a cookie.
        /// </summary>
        /// <param name="email">User email (has to be unique)</param>
        /// <param name="password">User password</param>
        /// <returns>A response indicating success if the user was registered, exception and message if login failed.</returns>
        public IServiceResponse Login(string email, string password)
        {
            foreach (var item in listOfUsers)
            {
                if (item.Email == email)
                {
                    Console.WriteLine("There is an email!");

                    //Måste koppla password till något, ID?
                    //if (item.Password == password)
                    //{
                    //    Console.WriteLine("Successfully logged in!");
                    //}
                }
            }

            throw new ArgumentOutOfRangeException($"{email} and {password} does not match");
        }

        /// <summary>
        /// Registers a new user.
        /// </summary>
        /// <param name="user">The user to register</param>
        /// <returns>A response indicating success if the user was registered, exception and message if registration failed.</returns>
        public IServiceResponse Register(IUser user)
        {


            //foreach (var item in listOfUsers)
            //{
            //    if (item.Name == user)
            //    {
            //        Console.WriteLine($"There is already an Email named {user}");
            //    }
            //}

            Console.WriteLine("User Added Successfully!");
            return null;
        }


        /// <summary>
        /// Sets the password for a user.
        /// </summary>
        /// <param name="userId">The users internal id</param>
        /// <param name="password">The password to set</param>
        /// <returns>A response indicating success if the password was set, exception and message if operation failed.</returns>
        public IServiceResponse SetPassword(Guid userId, string password)
        {
            throw new NotImplementedException();
        }

        public class Authenticator
        {
            static private Authenticator auth = new Authenticator();
            private Dictionary<string, string> Passwords = new Dictionary<string, string>();
            public Authenticator(string username, string password)
            {
                Passwords.Add(username, password);
            }

            public bool ValidateCredentials(string username, string password)
            {
                return Passwords.Any(entry => entry.Key == username && entry.Value == password);
            }
        }
    }
}
