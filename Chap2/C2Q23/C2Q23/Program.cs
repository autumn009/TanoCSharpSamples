using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 13, 3, 7 };
        foreach (var item in from n in numbers where n >= 7 orderby n select n)
        {
            Console.WriteLine(item);
        }
    }
}
