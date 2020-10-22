using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Users.Common.Services;

namespace Users.Common.Tools
{
    public static class UserLogin
    {
        public static void Init()
        {
            Console.WriteLine("Hello, and welcome to our login service. Please enter your username:");
            string username = Console.ReadLine();
            if (UserLogin.Find(username))
            {
                Console.WriteLine("Please enter your password.");
                string password = Console.ReadLine();
                if (Hash.Compare(username, password))
                    Console.WriteLine($"Welcome back, {username}");
                else
                {
                    Console.WriteLine("Invalid password.");
                    Init();
                }
            }
            else
            {
                string password = InputOrGenerate();
                UserLogin.CreateUser(username, password);
                Init();
            }
        }

        public static string InputOrGenerate()
        {
            Console.WriteLine("User not found.");
            Console.WriteLine("Would you like to make your own password or have one generated for you?\n   (input 1 and [enter] for your own, 2 and [enter] for generated.)");
            char input = ReadInputNumber();
            if (input == '1')
            {
                Console.WriteLine("Now please enter your password:");
                return Console.ReadLine();
            }
            else
            {
                PasswordService passServ = new PasswordService();
                string password = passServ.GeneratePassword(20, 5, 4, 3);
                Console.WriteLine($"Your new password is {password}");
                return password;
            }
        }

        public static char ReadInputNumber()
        {
            try
            {
                char input = Convert.ToChar(Console.ReadLine());
                if (input == '1' | input == '2')
                    return input;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try again.");
                    Console.WriteLine("Would you like to make your own password or have one generated for you? (input 1 and [enter] for your own, 2 and [enter] for generated.)");
                    return ReadInputNumber();
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid input, try again.");
                Console.WriteLine("Would you like to make your own password or have one generated for you? (input 1 and [enter] for your own, 2 and [enter] for generated.)");
                return ReadInputNumber();
            }
        }
            

        public static void CreateUser(string username, string password)
        {
            string salt = Salt.Generate();
            string hash = Hash.Generate(password, salt);
            string entireDatabase;
            using (FileStream stream = File.Open("C:\\plushogskolan\\programmeringsteknik-c\\Users\\UsersCmd\\bin\\Debug\\netcoreapp3.1\\Database\\UsersDatabase.bin", FileMode.Open))
            {

                using (StreamReader reader = new StreamReader(stream))
                {
                    entireDatabase = reader.ReadToEnd();
                    reader.Close();
                }
                stream.Close();
            }
            using (FileStream stream = File.Create("C:\\plushogskolan\\programmeringsteknik-c\\Users\\UsersCmd\\bin\\Debug\\netcoreapp3.1\\Database\\UsersDatabase.bin"))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(entireDatabase);
                    writer.WriteLine($"{username};{hash};{salt}");
                }
            }
        }

        public static bool Find(string username)
        {
            bool usernameFound = false;
            using (FileStream stream = File.Open("C:\\plushogskolan\\programmeringsteknik-c\\Users\\UsersCmd\\bin\\Debug\\netcoreapp3.1\\Database\\UsersDatabase.bin", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string row = reader.ReadLine();
                        string[] splitRow = row.Split(';');
                        if (splitRow[0] == username)
                            usernameFound = true;
                    }
                }
                stream.Close();
            }
            return usernameFound;
        }

        public static bool Login(string username, string password)
        {
            bool foundUser = Find(username);
            bool isPasswordCorrect = false;
            if (foundUser)
                isPasswordCorrect = Hash.Compare(username, password);
            else
            {
                UserLogin.CreateUser(username, password);
                Console.WriteLine("User not found. New user generated.");
            }
            return isPasswordCorrect;
        }

        public static string FindHash(string username, string password)
        {
            string[] splitRow;
            string hash = "";
            using (FileStream stream = File.Open("C:\\plushogskolan\\programmeringsteknik-c\\Users\\UsersCmd\\bin\\Debug\\netcoreapp3.1\\Database\\UsersDatabase.bin", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string row = reader.ReadLine();
                        if (row.Contains(username))
                        {
                            splitRow = row.Split(';');
                            hash = splitRow[1];
                        }
                    }
                    reader.Close();
                }
                stream.Close();
            }
            if (hash == "")
                throw new Exception("Hash Not Found");
            else
                return hash;
        }
    }
}
