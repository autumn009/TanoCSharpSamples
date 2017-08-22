using System;
using u1 = UltraLongLongLongLongLongLongNamespace1;
using u2 = UltraLongLongLongLongLongLongNamespace2;

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
        u1.A.X();
        u2.A.X();
    }
}
