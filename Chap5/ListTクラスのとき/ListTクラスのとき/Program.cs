using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // たろうくんは80点
        // じろうくんは65点
        // 遅刻したさぶろうくんは95点
        var tokuten = new List<int>() { 80, 65, 95 };
        Console.WriteLine(tokuten.Sum());
    }
}
