using System;

class Program
{
    static void Main(string[] args)
    {
#if (false && true) || false
        Console.WriteLine("case one");
#elif (false || true) && !false
        Console.WriteLine("case two");
#else
        Console.WriteLine("case three");
#endif
    }
}
