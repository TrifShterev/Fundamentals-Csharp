using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = Console.ReadLine();
            DateTime strtDate= DateTime.ParseExact(startDate, "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = Console.ReadLine();
           DateTime endDte= DateTime.ParseExact(endDate,
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = strtDate; date <= endDte;date= date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday ||
date.DayOfWeek == DayOfWeek.Sunday)
            { holidaysCount++; }
        }
        Console.WriteLine(holidaysCount);
    }
}