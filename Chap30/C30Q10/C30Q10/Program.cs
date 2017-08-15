using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new int[] { 1, 2, 3 }.ToList();
        foreach (var item in list) Console.WriteLine(item);
    }
}
