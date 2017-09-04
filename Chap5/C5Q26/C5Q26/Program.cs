using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        var b = new List<int>() { a, a, a };
        Console.WriteLine(b.Sum());
    }
}
