using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] a = { "Hello!", "C#" };
        IEnumerable<object> b;
        b = (IEnumerable<object>)a;
        //b = a.Cast<object>();
        foreach (var item in b) Console.WriteLine(item);
    }
}
