using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("これより開始します。");
        var t = Task.Delay(10000);
        t.ContinueWith((task) =>
        {
            Console.WriteLine("待機終了");
        });
        Console.WriteLine("メソッド呼び出し終了。10秒に待機を終了します。");
        Console.WriteLine("Enterキーで終了します。");
        Console.ReadLine();
    }
}
