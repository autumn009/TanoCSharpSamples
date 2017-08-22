using System;

namespace UltraLongLongLongLongLongLongNamespace1
{
    class A
    {
        internal static void X()
        {
            Console.WriteLine("in X part-1");
        }
    }
}

namespace UltraLongLongLongLongLongLongNamespace2
{
    class A
    {
        internal static void X()
        {
            Console.WriteLine("in X part-2");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        UltraLongLongLongLongLongLongNamespace1.A.X();
        UltraLongLongLongLongLongLongNamespace2.A.X();
    }
}
