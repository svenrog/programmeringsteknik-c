using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> returnDictionary = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        foreach (char character in sequence)
        {
            switch (character)
            {
                case 'A':
                    returnDictionary['A']++;
                    break;
                case 'C':
                    returnDictionary['C']++;
                    break;
                case 'G':
                    returnDictionary['G']++;
                    break;
                case 'T':
                    returnDictionary['T']++;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        return returnDictionary;
    }
}