using System;

class Program
{
    private static void sample(Action act)
    {
    }

    static void Main(string[] args)
    {
        sample(() =>
        {
            Console.WriteLine("Hello!");
        });
    }
}
