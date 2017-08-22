using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static IEnumerable<string> GetData()
    {
        Console.WriteLine("checkpoint-1");
        yield return "Return-1";
        Console.WriteLine("checkpoint-2");
        yield return "Return-2";
        Console.WriteLine("checkpoint-3");
    }
    static void Main(string[] args)
    {
        Console.WriteLine(GetData().First());
    }
}
