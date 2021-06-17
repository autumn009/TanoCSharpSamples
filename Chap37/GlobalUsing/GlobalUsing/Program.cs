using System;

class Program
{
    static void Main()
    {
        WriteLine($"Main {string.Join(',', Enumerable.Range(0, 3))}");
        Class1.Sub();
    }
}
