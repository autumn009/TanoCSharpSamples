using System;

class Program
{
    private static int x = int.TryParse("123", out var y) ? y : 0;

    static void Main() => Console.WriteLine(x);
}
