using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 123;
        Func<int, int> act = (a) =>
        {
            return a * 2;
        };
        x = act(x);
        Console.WriteLine(x);
    }
}
