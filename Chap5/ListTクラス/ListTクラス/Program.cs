using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] tokuten = new int[2]; // テストを受けたのは二人だ
        tokuten[0] = 80;    // たろうくんは80点
        tokuten[1] = 65;    // じろうくんは65点
        //tokuten[2] = 95;    // 遅刻したさぶろうくんは95点
        Console.WriteLine(tokuten.Sum());
    }
}

