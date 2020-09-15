using System;

class Program
{
    static void Main()
    {
        Half a = (Half)1.0f;
        Half b = (Half)0.5f;
        Half c = Half.PositiveInfinity;
        Half d = Half.NaN;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
}
