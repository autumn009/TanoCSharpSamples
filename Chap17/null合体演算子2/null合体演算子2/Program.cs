using System;

class Program
{
    static void Main(string[] args)
    {
        string a = null;
        string b = "僕はbだ。";
        Console.WriteLine(a ?? "aはnullです。");
        Console.WriteLine(b ?? "bはnullです。");
    }
}
