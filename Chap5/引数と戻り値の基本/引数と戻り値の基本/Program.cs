using System;

class Program
{
    private static string sample(int hiki)
    {
        Console.WriteLine("sampleメソッドが実行されました。引数は{0}です。", hiki);
        return "OK";
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Mainメソッドが実行されました。");
        var ret = sample(4649);
        Console.WriteLine("戻り値は{0}です。", ret);
    }
}
