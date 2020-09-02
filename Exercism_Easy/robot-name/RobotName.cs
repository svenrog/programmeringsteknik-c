using System;
using System.ComponentModel.Design;

public class Robot
{
    private string _name;

    public Robot()
    {
        _name = NewName();
    }
    public string Name
    {
        get => _name;
        set => _name = NewName();
    }

    public void Reset()
    {
        _name = NewName();
    }
    static string NewName()
    {
        string name = "";
        Random rnd = new Random();
        for (int i = 0; i < 2; i++)
        {
            char randomChar = (char)rnd.Next('A', 'Z');
            name += randomChar;
        }
        for (int i = 0; i < 3; i++)
        {
            char randomChar = (char)rnd.Next('1', '9');
            name += randomChar;
        }
        return name;
    }
}