using System;

class Program
{
    static void Main()
    {
        var a = 1234;
        var b = 5678;
        ref var c = ref a;
        Console.WriteLine(c);
        c = ref b;
        Console.WriteLine(c);
    }
}
