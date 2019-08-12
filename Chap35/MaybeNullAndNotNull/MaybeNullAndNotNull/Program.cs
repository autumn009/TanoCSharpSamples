#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    [return: MaybeNull]
    private static string? Sub1(bool b)
    {
        if (b) return "Hello1"; else return null;
    }

    [return: NotNull]
    private static string? Sub2()
    {
        return "Hello2";
    }

    static void Main()
    {
        string s = Sub1(true)?.Trim() + Sub2().Trim();
        Console.WriteLine(s);
    }
}
