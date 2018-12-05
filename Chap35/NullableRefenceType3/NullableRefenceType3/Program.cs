using System;
#nullable enable

class Program
{
    private static void sub( string? s)
    {
        if( s != null)
        {
            Console.WriteLine(s.ToUpper());
        }
        Console.WriteLine(s?.ToUpper());
    }

    static void Main()
    {
        string? a = "Hello!";
        Console.WriteLine(a.ToUpper());
        sub(a);
    }
}
