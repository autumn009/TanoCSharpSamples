using System;

class Program
{
    static void Main(string[] args)
    {
        string a = null;
        string b = "僕はbだ。";

        if (a == null)
            Console.WriteLine("aはnullです。");
        else
            Console.WriteLine(a);

        if (b == null)
            Console.WriteLine("bはnullです。");
        else
            Console.WriteLine(b);
    }
}
