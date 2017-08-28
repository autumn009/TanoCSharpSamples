using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 123;
        Action act = () =>
        {
            x *= 2;
        };
        act();
        Console.WriteLine(x);
    }
}
