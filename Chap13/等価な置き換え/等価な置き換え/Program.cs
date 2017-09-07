using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var a = new Dictionary<int, string>();
        a[51] = "AREA";
        a[7] = "ULTRA";
        Console.WriteLine(a[7]);
        Console.WriteLine(a[51]);
    }
}
