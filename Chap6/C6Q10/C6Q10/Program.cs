using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        if (a++ == 1)
            Console.WriteLine("aは1です。");
        else
            Console.WriteLine("aは1ではありません。");
        Console.WriteLine("aは{0}です。", a);
    }
}
