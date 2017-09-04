using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var tokuten = new List<int>();
        tokuten.Add(80);    // たろうくんは80点
        tokuten.Add(65);    // じろうくんは65点
        tokuten.Add(95);    // 遅刻したさぶろうくんは95点
        Console.WriteLine(tokuten.Sum());
    }
}
