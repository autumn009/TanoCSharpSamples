using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Enumerable.Repeat(1.0, 1000).Sum());
    }
}
