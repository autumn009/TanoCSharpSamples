using System;
using Sample2;

namespace Sample1
{
    class A
    {
        public void Method1()
        {
            Console.WriteLine("in class A");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var x = new A();
            x.Method1();
            x.Method2();
        }
    }
}

namespace Sample2
{
    static class B
    {
        public static void Method2(this Sample1.A a)
        {
            a.Method1();
            Console.WriteLine("in class B");
        }
    }
}
