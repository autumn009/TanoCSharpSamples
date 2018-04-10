using System;

class Program
{
    static void Main()
    {
        Span<int> x = stackalloc[] { 1, 2, 3 };
        foreach (var item in x) Console.Write(item);
    }
}
