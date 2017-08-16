using System;

class Program
{
    static void Main(string[] args)
    {
        (string First, string Second) x = ("1", "2");
        // direct accesss
        Console.WriteLine(x.First);
        // reflection access
        var f = x.GetType().GetField("First");
        Console.WriteLine(f != null);
    }
}
