using System;

public class SpaceAge
{
    double secondsFloat;
    public SpaceAge(int seconds)
    {
        secondsFloat = (double)seconds;
    }

    public double OnEarth()
    {
        return Math.Round(secondsFloat / 31557600, 2);
    }

    public double OnMercury()
    {
        return Math.Round((secondsFloat / 31557600) / 0.2408467, 2);
    }

    public double OnVenus()
    {
        return Math.Round((secondsFloat / 31557600) / 0.61519726, 2);
    }

    public double OnMars()
    {
        return Math.Round((secondsFloat / 31557600) / 1.8808158, 2);
    }

    public double OnJupiter()
    {
        return Math.Round((secondsFloat / 31557600) / 11.862615, 2);
    }

    public double OnSaturn()
    {
        return Math.Round((secondsFloat / 31557600) / 29.447498, 2);
    }

    public double OnUranus()
    {
        return Math.Round((secondsFloat / 31557600) / 84.016846, 2);
    }

    public double OnNeptune()
    {
        return Math.Round((secondsFloat / 31557600) / 164.79132, 2);
    }
}