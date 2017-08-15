using System;
using System.Linq;

class Program
{
    public static int CountOfBetween(int[] array, int upper, uint lower) => array.Count(c => c >= lower && c <= upper);


    static void Main(string[] args)
    {
        int[] ar = { 1, 2, 3, 4, 5 };
        Console.WriteLine(CountOfBetween(ar, 4, 2));
    }
}

