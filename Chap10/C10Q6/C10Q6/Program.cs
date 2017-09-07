using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int single = 1;
        Console.WriteLine((double)single);
        int[] array = { 1 };
        foreach (var item in array.Cast<double>())
        {
            Console.WriteLine(item);
        }
    }
}
