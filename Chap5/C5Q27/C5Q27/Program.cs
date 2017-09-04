using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var list = new List<int>() { 1, 2, 3 };
        list.RemoveAt(1);
        foreach (var item in list) Console.WriteLine(item);
    }
}
