using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Enumerable.Repeat(0.1, 1000).Sum());
        Console.WriteLine(Enumerable.Repeat(0.1f, 1000).Sum());
    }
}
