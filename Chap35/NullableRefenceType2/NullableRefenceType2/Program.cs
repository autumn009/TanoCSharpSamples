using System;
#nullable enable

class Program
{
    private static void sub(string a, string b, string c, string d)
    {
        Console.WriteLine(a.ToUpper() + b.ToLower() + c.ToUpper() + d.ToLower());
    }

    private static void not(string? a, string? b, string? c, string? d)
    {
        Console.WriteLine(a?.ToUpper() + b?.ToLower() + c?.ToUpper() + d?.ToLower());
    }

    static void Main()
    {
        not("h", "ello", "w", "orld");
        not("h", "ello", "w", null);
        sub("h", "ello", "w", "orld");
        sub("h", "ello", "w", null);
    }
}
