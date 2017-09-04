using System;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime dt = new DateTime(1999, 7, 7);
        dt.AddDays(1);
        Console.WriteLine(dt.ToShortDateString());
    }
}
