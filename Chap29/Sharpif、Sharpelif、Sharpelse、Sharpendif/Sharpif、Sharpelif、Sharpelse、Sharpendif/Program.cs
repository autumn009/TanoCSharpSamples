#define MY_SYMBOL2
using System;

class Program
{
    static void Main(string[] args)
    {
#if MY_SYMBOL1
        Console.WriteLine("MY_SYMBOL1が定義されています。");
#elif MY_SYMBOL2
        Console.WriteLine("MY_SYMBOL2が定義されています。");
#else
        Console.WriteLine("MY_SYMBOL1も2もが定義されていません。");
#endif
    }
}

