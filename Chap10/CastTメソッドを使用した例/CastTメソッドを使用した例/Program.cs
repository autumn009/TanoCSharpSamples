using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        object[] array = { 1, 2, 3 };
        foreach (int item in array.Cast<int>())
        {
            Console.WriteLine(item);
        }
    }
}
