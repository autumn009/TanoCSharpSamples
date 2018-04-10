using System;

class Program
{
    static void Main()
    {
        var t1 = (1, 2);
        var t2 = (1, 2);
        Console.WriteLine(t1 == t2);
        Console.WriteLine(t1 != t2);
    }
}
