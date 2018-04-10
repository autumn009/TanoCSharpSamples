using System;

class Program
{
    static void Main()
    {
        var a1 = (1, 2);
        var b1 = (1.0, 2.0);
        Console.WriteLine(a1 == b1);
    }
}
