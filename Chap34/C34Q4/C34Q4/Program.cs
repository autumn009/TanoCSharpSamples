using System;

class Program
{
    private static bool x = int.TryParse("123", out var r);
    private static int y = r;

    static void Main() => Console.WriteLine(x ? y : 0);
}
