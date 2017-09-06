using System;

class Program
{
    private static void a()
    {
        b();
        Console.WriteLine("method a");
    }
    private static void b()
    {
        a();
        Console.WriteLine("method b");
    }

    static void Main(string[] args)
    {
        a();
        Console.WriteLine("all done");
    }
}
