using System;

namespace WhichHolidayApp
{
    class Program
    {
		private static string hollyday;
		static void Main(string[] args)
        {
			// Implementera följande flödesschema med metoder och användarinmatning
			// https://pbs.twimg.com/media/EQup9bwXUAEK5a_?format=jpg&name=large
			string[] questionArray = new string[11]
			{
				"Äter man sill?",
				"Dricker man must?",
				"Är fika viktigt?",
				"Kollar man TV kl 15:00?",
				"Vispgrädde?",
				"Importerat från USA av köpman?",
				"Sylt till",
				"Vad köper man?",
				"Är man bakfull?",
				"kollar man på Ivanhoe?",
				"Vet folk orsaken till firandet?"
			};
			string[,] answerArray = new string[11, 2]
			{
				{null, null},
				{null, "Midsommar"},
				{null, null},
				{"Jul","Påsk"},
				{null,"Kanebullens dag"},
				{null,null},
				{"Våffeldagen","Fettisdagen"},
				{"Alla hjärtans dag","Halloween"},
				{null,null},
				{"Nyårsdagen","Föra maj"},
				{"Kristihimmelsfärd","Nationaldagen"}
			};
			int[,] links = new int[11, 2]
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
					pathIndex = GetAnswer(questionArray, answerArray, links, pathIndex);
				}
				Console.WriteLine("Då är det " + hollyday);
				hollyday = null;
				pathIndex = 0;
			}
		}

		private static int GetAnswer(string[] questionArray, string[,] answerArray, int[,] links, int pathIndex)
		{
			Console.WriteLine(questionArray[pathIndex]);
			string input = Console.ReadLine();
			input = input.ToLower();
			if (input == "ja")
			{
				hollyday = answerArray[pathIndex, 0];
				return links[pathIndex, 0];
			}
			hollyday = answerArray[pathIndex, 1];
			return links[pathIndex, 1];
		}
	}


}
