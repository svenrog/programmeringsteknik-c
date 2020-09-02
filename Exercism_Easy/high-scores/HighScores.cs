using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class HighScores
{
    List<int> highScoresList = null;
    public HighScores(List<int> list)
    {
        highScoresList = list;
    }

    public List<int> Scores()
    {
        return highScoresList;
    }

    public int Latest()
    {
        return highScoresList[highScoresList.Count - 1];
    }

    public int PersonalBest()
    {
        int highestScore = 0;
        foreach (int score in highScoresList)
        {
            foreach (int score2 in highScoresList)
            {
                if (score > score2 & score > highestScore) highestScore = score;
            }
        }
        return highestScore;
    }

    public List<int> PersonalTopThree()
    {
        List<int> inputScoresList = highScoresList;
        List<int> topThreeScoresList = new List<int> { };

        void AddHighestScoreToList()
        {
            
            if (inputScoresList.Count > 0)
            {
                int highestScore = 0;
                int index = 0;
                for (int i = 0; i<inputScoresList.Count;i++)
                {
                    foreach (int score in inputScoresList)
                    {
                        if (inputScoresList[i] > score & inputScoresList[i] > highestScore)
                        {
                            highestScore = inputScoresList[i];
                            index = i;
                        }
                    }
                }
                topThreeScoresList.Add(inputScoresList[index]);
                inputScoresList.Remove(inputScoresList[index]);
            }
        }
        AddHighestScoreToList();
        AddHighestScoreToList();
        AddHighestScoreToList();
        return topThreeScoresList;
    }
}