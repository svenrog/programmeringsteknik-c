using System;

/**
* @author Edgar Runnman
*
* @date - 2020-09-01 
*/

namespace HolidayApp
{
    class Program
    {
		private static string hollyday;
		static void Main(string[] args)
        {
			// Implementera följande flödesschema med metoder och användarinmatning
			// https://pbs.twimg.com/media/EQup9bwXUAEK5a_?format=jpg&name=large

			string[][] questionJaggedArray = 
			{
				new string[] {"Äter man sill?", "ja", "nej", null, null, "1", "2"},
				new string[] {"Dricker man must?", "ja", "nej", null, "Midsommar", "3", null},
				new string[] {"Är fika viktigt?", "ja", "nej", null, null, "4", "5"},
				new string[] {"Kollar man TV kl 15:00?", "ja", "nej", "Jul","Påsk", null, null},
				new string[] {"Vispgrädde?", "ja", "nej", null,"Kanebullens dag", "6", null},
				new string[] {"Importerat från USA av köpman?", "ja", "nej", null, null, "7", "8"},
				new string[] {"Sylt till", "ja", "nej", "Våffeldagen", "Fettisdagen", null, null},
				new string[] {"Vad köper man?", "rosor", "pumpor", "Alla hjärtans dag", "Halloween", null, null},
				new string[] {"Är man bakfull?", "ja", "nej", null, null, "9", "10"},
				new string[] {"kollar man på Ivanhoe?", "ja", "nej", "Nyårsdagen", "Föra maj", null, null},
				new string[] {"Vet folk orsaken till firandet?", "ja", "nej", "Kristihimmelsfärd", "Nationaldagen", null, null }
			};

			int pathIndex = 0;
			Console.WriteLine("Vilken svensk högtid?");
			while (hollyday == null)
			{
				pathIndex = GetAnswer(questionJaggedArray, pathIndex);
			}
			Console.WriteLine("Då är det " + hollyday);
		}

		private static int GetAnswer(string[][] questionJaggedArray, int pathIndex)
		{
			string question = 
				$"{questionJaggedArray[pathIndex][0]} (Svara med \"{questionJaggedArray[pathIndex][1]}\" eller \"{questionJaggedArray[pathIndex][2]}\")";
			Console.WriteLine(question);
			string input = null;
			input = Console.ReadLine();
			input = input.ToLower();
			if (input == questionJaggedArray[pathIndex][1])
			{
				hollyday = questionJaggedArray[pathIndex][3];
				return Convert.ToInt32(questionJaggedArray[pathIndex][5]);
			}
			else if (input == questionJaggedArray[pathIndex][2])
			{
				hollyday = questionJaggedArray[pathIndex][4];
				return Convert.ToInt32(questionJaggedArray[pathIndex][6]);
			}
			else
			{
				Console.WriteLine("Fel i svaret, prova igen!");
				return pathIndex;
			}
		}
	}


}
