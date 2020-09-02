using System;
using System.Runtime.InteropServices.WindowsRuntime;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] colors = Colors();
        int index = 0;
        int CodeValueToReturn = 100;
        color = color.ToUpper();
        foreach (string colorCodeText in colors)
        {
            string colorCodeTextUpper = colorCodeText.ToUpper();
            if (colorCodeTextUpper == color) CodeValueToReturn = index;
            index++;
        }
        return CodeValueToReturn;
    }

    public static string[] Colors()
    {
        string[] mystring = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return mystring;
    }
}