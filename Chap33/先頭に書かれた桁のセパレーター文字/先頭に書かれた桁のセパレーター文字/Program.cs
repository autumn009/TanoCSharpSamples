using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(0x1_0);   // OK in C# 7.0
        Console.WriteLine(0x_1_0);  // OK in C# 7.2
    }
}
