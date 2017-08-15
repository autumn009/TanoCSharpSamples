using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> names1 = new List<string>
            {
                "One",
                "Two",
                "Three"
            };
        Dictionary<int, string> names2 = new Dictionary<int, string>
        {
            [1] = "Ken",
            [2] = "Joe",
            [3] = "Jun"
        };
        foreach (var item in names1) Console.WriteLine(item);
        foreach (var item in names2.Keys) Console.WriteLine("{0}={1}", item, names2[item]);
    }
}


