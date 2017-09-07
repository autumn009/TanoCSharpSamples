using System;

class Program
{
    private static void yourType(object o)
    {
        if (o is int) Console.WriteLine("{0}は整数でした。", o);
        if (o is string) Console.WriteLine("{0}は文字列でした。", o);
    }

    static void Main(string[] args)
    {
        yourType(1);
        yourType("1");
    }
}
