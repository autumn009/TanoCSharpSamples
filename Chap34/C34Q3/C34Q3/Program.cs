using System;

class Program
{
    static void Main()
    {
        Span<int> x = stackalloc[] { 1, 2, 3 };
        Action t = () => Console.WriteLine(x[0]);
        t();
    }
}
