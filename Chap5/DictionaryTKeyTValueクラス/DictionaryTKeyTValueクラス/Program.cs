using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var tokuten = new Dictionary<string, int>();
        tokuten.Add("たろう", 80);    // たろうくんは80点
        tokuten.Add("じろう", 65);    // じろうくんは65点
        tokuten.Add("さぶろう", 95);    // 遅刻したさぶろうくんは95点
        foreach (var item in tokuten)
        {
            Console.WriteLine("{0}くんは{1}点だ。", item.Key, item.Value);
        }
        Console.WriteLine(tokuten.Values.Sum());
    }
}
