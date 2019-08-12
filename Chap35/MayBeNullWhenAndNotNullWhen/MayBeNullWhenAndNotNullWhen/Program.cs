#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    private static bool tryParseClassName(char ch, [NotNullWhen(true)] out string? name)
    {
        if (ch == 'Y')
        {
            name = "3年Y組ニャンパチ先生";
            return true;
        }
        name = null;
        return false;
    }

    private static void report(string s)
    {
        Console.WriteLine(s);
    }

    static void Main()
    {
        if (tryParseClassName('Y', out string? r))
        {
            report(r);
            return;
        }
        //report(r);
        Console.WriteLine("Unknown Class");
    }
}
