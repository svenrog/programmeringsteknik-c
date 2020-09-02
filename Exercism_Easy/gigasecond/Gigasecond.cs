using System;
using System.Runtime.Serialization;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        int sekunder = 1_000_000_000;
        int notWholeDay = sekunder % 86400;
        int days = (sekunder - notWholeDay) / 86400;
        int notWholeHour = notWholeDay % 3600;
        int hours = (notWholeDay - notWholeHour) / 3600;
        int notWholeMinute = notWholeHour % 60;
        int minutes = (notWholeHour - notWholeMinute) / 60;
        int seconds = notWholeMinute;
        TimeSpan gigaSecond = new TimeSpan(days, hours, minutes, seconds);
        return moment + gigaSecond;
    }
}