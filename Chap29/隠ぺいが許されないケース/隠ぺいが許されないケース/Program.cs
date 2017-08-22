using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 123;
        {
            int x = 456;
            Console.WriteLine(x);
        }
        Console.WriteLine(x);
    }
}
