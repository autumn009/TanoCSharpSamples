using System;

class Program
{
    static void Main(string[] args)
    {
        string a = "World!";
        if (a == null || !a.StartsWith("H"))
        {
            Console.WriteLine("最初の1文字はHではありません。");
        }
    }
}
