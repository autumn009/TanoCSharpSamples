using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var tokuten = new Dictionary<string, int>()
        {
            { "たろう", 80 },    // たろうくんは80点
            { "じろう", 65 },    // じろうくんは65点
            { "さぶろう", 95 }    // 遅刻したさぶろうくんは95点

        };
        foreach (var item in tokuten)
        {
            Console.WriteLine("{0}くんは{1}点だ。", item.Key, item.Value);
        }
        Console.WriteLine(tokuten.Values.Sum());
    }
}
