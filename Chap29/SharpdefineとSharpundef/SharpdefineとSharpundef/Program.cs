#define MY_SYMBOL
using System;

class Program
{
    static void Main(string[] args)
    {
#if MY_SYMBOL
        Console.WriteLine("MY_SYMBOLが定義されています。");
#endif
#if DEBUG
        Console.WriteLine("DEBUGが定義されています。");
#endif
    }
}
