using System;
using System.Collections.Generic;
/**
* @author Edgar Runnman
* @edgar.runnman@gmail.com
* @date - 2020-09-01 
*/
namespace WordAndLetterOrderChengerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Skirv in fre text och se vad som händer!");
                string input = Console.ReadLine();
                int inputLength = input.Length;
                Console.WriteLine("\nHär är din text där ordordning och bokstaver är baklänges:");
                for (int i = 0; i < inputLength; i++)
                {
                    int index = inputLength - 1 - i;
                    Console.Write(input[index]);
                }
                Console.WriteLine("\n\nHär är din text där bara ordordning är baklänges:");
                input += " ";
                List<string> StringList = new List<string>();
                string word = "";
                foreach (char character in input)
                {
                    if (character == ' ')
                    {
                        StringList.Add(word);
                        word = "";
                    }
                    else
                    {
                        word += character;
                    }
                }
                int stringLengts = StringList.Count;
                for (int i = 0; i < stringLengts; i++)
                {
                    int index = stringLengts - 1 - i;
                    //Console.WriteLine(index);
                    Console.Write(StringList[index] + " ");
                }
                Console.WriteLine("\n\nProva igen!");
            }
        }
    }
}

