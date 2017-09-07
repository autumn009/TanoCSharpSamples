using System;

public class Program
{
    public static void Main(string[] args)
    {
        TimeSpan ts = DateTime.Now - DateTime.Today;
        Console.WriteLine(ts);
    }
}
