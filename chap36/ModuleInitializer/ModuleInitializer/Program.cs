using System;
using System.Runtime.CompilerServices;

class Program
{
    [ModuleInitializerAttribute]
    internal static void ModileInitialized()
    {
        Console.WriteLine("Modile Initialized");

    }

    static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}
