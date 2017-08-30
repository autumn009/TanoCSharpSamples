using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 7, 5, 3, 13 };
        foreach (var item in from n in numbers orderby n select n)
        //foreach (var item in numbers.OrderBy(c => c))
        {
            Console.WriteLine(item);
        }
    }
}
