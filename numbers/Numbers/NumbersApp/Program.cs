using System;
using System.Xml.Schema;

namespace NumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Ange ett antal nummer separerade med kommatecken:");
            string userInput = Console.ReadLine();
            
            string[] userInputArray = userInput.Split(",", StringSplitOptions.RemoveEmptyEntries);
            int lowestValue = int.MaxValue;
            int highestValue = int.MinValue;
            int sum = 0;
            int convertedNumbers;
            int countNumber = 0;
            
            for (int i = 0; i < userInputArray.Length; i++)
            {
                try
                {
                    convertedNumbers = Convert.ToInt32(userInputArray[i]);
                }
                catch(Exception)
                {
                    break;
                }
                
                if (lowestValue > convertedNumbers)
                    lowestValue = convertedNumbers;

                if (highestValue < convertedNumbers)
                    highestValue = convertedNumbers;
                countNumber++;
                sum = sum + convertedNumbers;  
            }
            int average = sum / countNumber;
            Console.WriteLine($"\nLägsta värdet är: {lowestValue}\nHögsta värdet är: {highestValue}\nMedelvärdet är: {average}");

            Console.ReadKey();   
        }
    }
}
