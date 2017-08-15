using System;

namespace A
{
    class B
    {
        public static int C;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(nameof(A.B.C));
    }
}
