using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Users.Common.Tools
{
    public static class Hash
    {
        public static string Generate(string password, string salt)
        {
            //if (salt.Length < password.Length)
            //    throw new Exception("Password is too long.");
            SHA256 sha256 = SHA256.Create();
            string PepperAndPasswordAndSalt = Database.GlobalVariables.Pepper() + password + salt;
            List<byte> byteList = new List<byte>();

            foreach (char c in PepperAndPasswordAndSalt)
            {
                byteList.Add((byte)c);
            }
            byte[] byteArray = new byte[byteList.Count];
            int counter = 0;

            foreach (byte b in byteList)
            {
                byteArray[counter] = b;
                counter++;
            }

            byteArray = sha256.ComputeHash(byteArray);
            string hash = "";

            foreach (byte b in byteArray)
            {
                hash += (char)b;
            }
            hash = hash.Replace("\n", " ").Replace("\r", " ").Replace("\r\n", " ").Replace("\t", " ").Replace("\v", " ").Replace("\f", " ").Replace(';', '/');
            return hash;
        }

        public static bool Compare(string username, string password)
        {
            using (FileStream stream = File.Open("C:\\plushogskolan\\programmeringsteknik-c\\Users\\UsersCmd\\bin\\Debug\\netcoreapp3.1\\Database\\UsersDatabase.bin", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string row = reader.ReadLine();
                        if (row.Contains(username))
                        {
                            string[] splitRow = row.Split(';');
                            string hashFromDatabase = splitRow[1];
                            string saltFromDatabase = splitRow[2];
                            string hashFromGenerator = Hash.Generate(password, saltFromDatabase);
                            if (hashFromDatabase == hashFromGenerator)
                            {
                                reader.Close();
                                stream.Close();
                                return true;
                            }
                            else
                            {
                                reader.Close();
                                stream.Close();
                                return false;
                            }
                        }
                    }
                    reader.Close();
                }
                stream.Close();
            }
            throw new Exception("Invalid username or password");

        }
        public static string Get(string username, string password)
        {
            using (FileStream stream = File.Open("C:\\plushogskolan\\programmeringsteknik-c\\Users\\UsersCmd\\bin\\Debug\\netcoreapp3.1\\Database\\UsersDatabase.bin", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    if (Compare(username, password))
                    {
                        while (!reader.EndOfStream)
                        {
                            string row = reader.ReadLine();
                            if (row.Contains(username))
                            {
                                string[] splitRow = row.Split(';');
                                string hashFromDatabase = splitRow[1];
                                string saltFromDatabase = splitRow[2];
                                string hashFromGenerator = Hash.Generate(password, saltFromDatabase);
                                if (hashFromDatabase == hashFromGenerator)
                                {
                                    reader.Close();
                                    stream.Close();
                                    return hashFromDatabase;
                                }
                            }
                        }
                    }
                    reader.Close();
                }
                stream.Close();
            }
            throw new Exception("Invalid username or password");
        }
    }
}
