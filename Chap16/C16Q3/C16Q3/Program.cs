using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime start = new DateTime(2017, 10, 1);
        TimeSpan delta = TimeSpan.FromDays(7);
        start += delta;
        Console.WriteLine(start);
    }
}
