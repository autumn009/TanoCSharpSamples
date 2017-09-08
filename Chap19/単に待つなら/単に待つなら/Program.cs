using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("これより開始します。");
        Task.Delay(10000).Wait();
        Console.WriteLine("待機終了。");
    }
}
