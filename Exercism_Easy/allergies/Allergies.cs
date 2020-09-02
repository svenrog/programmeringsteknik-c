using System;
using System.Linq;

public enum Allergen
{
    Eggs = 0b_0000_0001,
    Peanuts = 0b_0000_0010,
    Shellfish = 0b_0000_0100,
    Strawberries = 0b_0000_1000,
    Tomatoes = 0b_0001_0000,
    Chocolate = 0b_0010_0000,
    Pollen = 0b_0100_0000,
    Cats = 0b_1000_0000
}

public class Allergies
{
    int allergienTestIndex;
    public Allergies(int mask)
    {
        allergienTestIndex = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        Allergen[] allergenList = List();
        return allergenList.Contains(allergen);
    }

    public Allergen[] List()
    {
        int listLenght = 0;
        int sumOfallergienTestIndex = 0;

        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            sumOfallergienTestIndex += (int)allergen;
            if ((allergienTestIndex & (int)allergen) != 0) listLenght++;
        }

        Allergen[] allergenList = new Allergen[listLenght];
        int i = 0;

        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if (listLenght == 0) break;
            if ((allergienTestIndex & (int)allergen) != 0)
            {
                allergenList[i] = allergen;
                listLenght--;
                i++;
            }
        }
        return allergenList;
    }
}