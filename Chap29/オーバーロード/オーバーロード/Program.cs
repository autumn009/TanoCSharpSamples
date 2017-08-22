using System;

class Program
{
    private static void method(int i)
    {
        Console.WriteLine("int:{0}", i);
    }
    private static void method(string s)
    {
        Console.WriteLine("string:{0}", s);
    }
    private static void method(int i, string s)
    {
        Console.WriteLine("int:{0}, string:{0}", i, s);
    }
    static void Main(string[] args)
    {
        method(1);
        method("1");
        method(1, "1");
    }
}
