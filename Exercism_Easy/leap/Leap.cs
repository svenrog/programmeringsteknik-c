using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        var divisibleByFour = year % 4;
        var divisibleByHundred = year % 100;
        var divisibleByFourHundred = year % 400;
        if ((divisibleByFour == 0) & (divisibleByFourHundred == 0)) return true;
        if ((divisibleByFour == 0) & (divisibleByHundred != 0)) return true;
        return false;

    }
}