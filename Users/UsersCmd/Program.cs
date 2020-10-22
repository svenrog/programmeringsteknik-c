using System;
using Users.Common.Services;

namespace Users.Cmd
{
    class Program
    {
        public static bool check = false;
        public static string answer = null;

        static void Main(string[] args)
        {
            // Skriv ett program som:
            // 1. Loggar in en användare.
            // 2. Om användaren inte existerar, registrerar användaren via inmatning och 
            //    låter användaren ange in ett lösenord,
            //    alt. genererar ett lösenord.
            // 3. Direkt efter ny användare registrerats, skall användaren kunna logga in (inloggning får ej ske automatiskt).


            // implementera IUserservice, Iuserresponse (Guid - lista för unika members)
            // en lista med mails för att kolla om det finns unika

            // Guid.NewGuid();


            // Gör en Dictionary<string, string>, lägg email som nyckel och lösen som värde.
            // Kolla sedan, if dictionary.ContainsKey(email)
            // efter det, om det är true, dictionary[email] == password

            // Login: email, password
            // setPassword: userId(guid), password
            // Dictionary<Guid, string> password
            // List<IUser>

            // UserLogin(email, pass)
            // {
            // Get(email)
            // returnerar IUser, kolla med dictionary
            // }


                Console.Write("Please Enter Email: ");
                var username = Console.ReadLine();

                Console.Write("\nPlease enter password: ");
                var password = Console.ReadLine();


                var isvalid = auth.ValidateCredentials(username, password);
                Console.WriteLine("Your are{0} authenticated!", isvalid ? string.Empty : " NOT");
                Console.ReadLine();
            


            Console.Write("Register new user (Y/N)? ");
            while (answer != "y" || answer != "Y")
            {
                answer = Console.ReadLine();

                if (answer == "Y" || answer == "y")
                {

                    Console.WriteLine(" Register User:");
                    Console.WriteLine("----------------\n");

                    var id = Guid.NewGuid();
                    Console.Write("Please enter name: ");
                    var name = Console.ReadLine();

                    Console.Write("Please enter email: ");
                    var email = Console.ReadLine();

                    Console.Write("Please enter phone number: ");
                    var phone = Console.ReadLine();


                    Console.Write("Do you want to recive newsletters Y/N?");
                    var subNewsLetters = Console.ReadLine();
                    bool newsLetters = true;

                    if (subNewsLetters == "N" || subNewsLetters == "n")
                    {
                        newsLetters = false;
                    }

                    UserService.AddUser(id, name, email, phone, newsLetters);

                    foreach(var item in listOfUsers)
                    {
                        Console.WriteLine(item.Name);
                    }


                }

                if (answer == "N" || answer == "n") { return; }
            }

            Console.Write("Please enter password: ");
            var password = Console.ReadLine();

             var newPassword = CreatePassword.CreatePasswords();

        }
        public static User RegisterUser(Guid id, string name, string email, string phone, bool sub)
        {


            return null;
        }
    }
}

