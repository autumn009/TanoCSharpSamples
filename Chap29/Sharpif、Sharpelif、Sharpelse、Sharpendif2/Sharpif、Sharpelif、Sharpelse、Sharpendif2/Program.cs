#define MY_SYMBOL2
using System;

class Program
{
    static void Main(string[] args)
    {
#if !MY_SYMBOL1 && MY_SYMBOL2
        Console.WriteLine("条件式に合致したシンボルが定義されています。");
#endif
    }
}
