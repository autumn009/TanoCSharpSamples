using System;

class Program
{
    private static int count = 0;

    static string get()
    {
        count++;
        return "Hello";
    }

    static void Main(string[] args)
    {
        Console.WriteLine(get()?.ToUpper());
        Console.WriteLine(count);
    }
}
