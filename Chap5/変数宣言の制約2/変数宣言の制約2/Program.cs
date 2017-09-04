using System;

class Program
{
    static void Main(string[] args)
    {
        int x1 = 123;
        {
            int x2 = 456;
            Console.WriteLine(x2);
        }
        Console.WriteLine(x1);
    }
}
