using System;
using System.Linq;

class Program
{
    private static int[] calc(int[] prices)
    {
        return (from n in prices select n * 105 / 100).ToArray();
    }

    static void Main(string[] args)
    {
        int[] prices = { 100, 200, 300 };
        int[] r = calc(prices);
        foreach (var item in r) Console.WriteLine(item);
    }
}
