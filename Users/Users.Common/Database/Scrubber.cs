using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Users.Common.Database
{
    public class Scrubber
    {
        public static void DeleteDatabase()
        {
            using (StreamWriter writer = new StreamWriter("C:\\plushogskolan\\programmeringsteknik-c\\Users\\UsersCmd\\bin\\Debug\\netcoreapp3.1\\Database\\UsersDatabase.bin"))
            {
                writer.Write("");
                writer.Close();
            }
        }
        public static void Run()
        {
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
            string[] splitByRows = entireDatabase.Split('\n');
            entireDatabase = "";
            for (int i = 0; i < splitByRows.Length; i++)
            {
                if (entireDatabase == "")
                {
                    if (splitByRows[i] != "\r")
                        entireDatabase = splitByRows[i];
                }
                else
                    if (splitByRows[i] != "")
                    entireDatabase += $"\n{splitByRows[i]}";
            }
            using (StreamWriter writer = new StreamWriter("C:\\plushogskolan\\programmeringsteknik-c\\Users\\UsersCmd\\bin\\Debug\\netcoreapp3.1\\Database\\UsersDatabase.bin"))
            {
                writer.Write(entireDatabase);
                writer.Close();
            }
        }
    }
}
