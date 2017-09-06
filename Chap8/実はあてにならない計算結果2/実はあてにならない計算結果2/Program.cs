using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine((double)Enumerable.Repeat(0.0123, 1000).Sum());
        Console.WriteLine((double)Enumerable.Repeat(0.0123f, 1000).Sum());
    }
}
