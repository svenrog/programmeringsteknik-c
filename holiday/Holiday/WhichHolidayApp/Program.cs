using System;

/**
* @author Edgar Runnman
*
* @date - 2020-09-01 
*/

namespace WhichHolidayApp
{
    class Program
    {
		private static string hollyday;
		static void Main(string[] args)
        {
			// Implementera följande flödesschema med metoder och användarinmatning
			// https://pbs.twimg.com/media/EQup9bwXUAEK5a_?format=jpg&name=large

			string[][] questionJaggedArray = new string[][]
			{
				new string[] {"Äter man sill?", "ja", "nej", null, null},
				new string[] {"Dricker man must?", "ja", "nej", null, "Midsommar"},
				new string[] {"Är fika viktigt?", "ja", "nej", null, null},
				new string[] {"Kollar man TV kl 15:00?", "ja", "nej", "Jul","Påsk"},
				new string[] {"Vispgrädde?", "ja", "nej", null,"Kanebullens dag"},
				new string[] {"Importerat från USA av köpman?", "ja", "nej", null, null},
				new string[] {"Sylt till", "ja", "nej", null, null},
				new string[] {"Vad köper man?", "rosor", "pumpor", "Våffeldagen","Fettisdagen"},
				new string[] {"Är man bakfull?", "ja", "nej", "Alla hjärtans dag","Halloween"},
				new string[] {"kollar man på Ivanhoe?", "ja", "nej", null, null},
				new string[] {"Vet folk orsaken till firandet?", "ja", "nej", "Nyårsdagen", "Föra maj" }
			};

			int[,] links = new int[,]
			{
				{1,2},
				{3,-1},
				{4,5},
				{-1,-1},
				{6,-1},
				{7,8},
				{-1,-1},
				{-1,-1},
				{9,10},
				{-1,-1},
				{-1,-1}
			};
			int pathIndex = 0;
			while (true)
			{
				Console.WriteLine("Vilken svensk högtid?");
				while (hollyday == null)
				{
					pathIndex = GetAnswer(questionJaggedArray, links, pathIndex);
				}
				Console.WriteLine("Då är det " + hollyday);
				hollyday = null;
				pathIndex = 0;
			}
		}

		private static int GetAnswer(string[][] questionJaggedArray, int[,] links, int pathIndex)
		{
			string question = $"{questionJaggedArray[pathIndex][0]} (Svara med \"{questionJaggedArray[pathIndex][1]}\" eller \"{questionJaggedArray[pathIndex][2]}\")";
			Console.WriteLine(question);
			string input = null;
			input = Console.ReadLine();
			input = input.ToLower();
			if (input == questionJaggedArray[pathIndex][1])
			{
				hollyday = questionJaggedArray[pathIndex][3];
				return links[pathIndex, 0];
			}
			else if (input == questionJaggedArray[pathIndex][2])
			{
				hollyday = questionJaggedArray[pathIndex][4];
				return links[pathIndex, 1];
			}
			else
			{
				Console.WriteLine("Fel i svaret, prova igen!");
				return pathIndex;
			}
		}
	}


}
