using System;

class Program
{
    static void test(Action<int> act)
    {
        act(1234);
    }
    static void Main()
    {
        test((_) =>
        {
            Console.WriteLine("It was called!");
        });
    }
}
