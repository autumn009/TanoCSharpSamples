using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 123;
        uint b;
        if (a >= 0)
            b = (uint)a;
        else
            b = 0;
        Console.WriteLine(b);
    }
}
