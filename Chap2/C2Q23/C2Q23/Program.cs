using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 13, 3, 7 };
        int[] r = (from n in numbers where n >= 7 orderby n select n).ToArray();
        Console.WriteLine(r[0]);
        Console.WriteLine(r[1]);
    }
}
