using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 7, 3, 5 };
        int[] r = (from n in numbers orderby n select n).ToArray();
        //int[] r = numbers.OrderBy(c => c).ToArray();
        Console.WriteLine(r[0]);
        Console.WriteLine(r[1]);
        Console.WriteLine(r[2]);
    }
}
