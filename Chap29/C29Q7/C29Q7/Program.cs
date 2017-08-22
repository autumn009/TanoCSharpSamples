using System;

class Program
{
    private static int method()
    {
        return 1;
    }
    private static string method()
    {
        return "1";
    }
    static void Main(string[] args)
    {
        Console.WriteLine(method());
    }
}
