using System;

class Program
{
    static void Main(string[] args)
    {
        string s = null;
        // old style
        s = s ?? "s is null";
        // C# 8.0 style
        s ??= "s is null";
        Console.WriteLine(s);
    }
}
