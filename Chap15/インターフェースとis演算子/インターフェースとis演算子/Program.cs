using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> a = new List<int>();
        Console.WriteLine(a is IEnumerable<int>);
    }
}
