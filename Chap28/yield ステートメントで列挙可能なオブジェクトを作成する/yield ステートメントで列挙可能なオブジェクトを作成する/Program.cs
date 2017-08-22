using System;
using System.Collections.Generic;

class Program
{
    private static IEnumerable<string> Steps()
    {
        yield return "Hop";
        yield return "Step";
        yield return "Jump";
    }

    static void Main(string[] args)
    {
        foreach (var item in Steps())
        {
            Console.WriteLine(item);
        }
    }
}
