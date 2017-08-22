using System;
using System.Collections.Generic;

class Program
{
    private static IEnumerable<string> getNames()
    {
        yield return "Taro";
        yield return "Jiro";
        yield break;
        yield return "Saburo";
    }

    static void Main(string[] args)
    {
        foreach (var item in getNames()) Console.WriteLine(item);
    }
}
