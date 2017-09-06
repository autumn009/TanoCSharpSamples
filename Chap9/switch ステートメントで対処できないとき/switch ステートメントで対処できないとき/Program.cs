using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 2, b = 2;
        if (a == 1)
            Console.WriteLine("aは1です。");
        else if (b == 1)
            Console.WriteLine("bは1です。");
        else if (b == 2)
            Console.WriteLine("bは2です。");
        else
            Console.WriteLine("いずれの条件も満たしません。");
    }
}
