using System;

class Program
{
    [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
    unsafe static void method()
    {
        Span<int> ar = stackalloc int[1];
        Console.WriteLine(ar[0]);
    }
    static void Main()
    {
        method();
    }
}
