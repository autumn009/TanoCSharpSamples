using System;

public class Program
{
    public static void Main(string[] args)
    {
        var a = 8823;
        var b = 2147483648;
        Console.WriteLine(a.GetType().FullName);
        Console.WriteLine(b.GetType().FullName);
    }
}
