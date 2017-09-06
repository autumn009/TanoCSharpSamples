using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Enumerable.Repeat(0.1 * 10.0, 1000).Sum() / 10.0);
        //Console.WriteLine(Enumerable.Repeat((int)(0.1 * 10.0), 1000).Sum() / 10.0);
    }
}
