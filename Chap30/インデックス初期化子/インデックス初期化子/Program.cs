using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> oldStyle = new Dictionary<int, string>
        {
            {1, "Old Ken" },
            {2, "Old Joe" },
            {3, "Old Jun" }
        };
        foreach (var item in oldStyle) Console.WriteLine("{0}={1}", item.Key, item.Value);
        Dictionary<int, string> newStyle = new Dictionary<int, string>
        {
            [1] = "New Ken",
            [2] = "New Joe",
            [3] = "New Jun"
        };
        foreach (var item in newStyle) Console.WriteLine("{0}={1}", item.Key, item.Value);
    }
}


