using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 123;
        System.Int32 b = 123;
        Console.WriteLine("aのフルネームは{0}", a.GetType().FullName);
        Console.WriteLine("bのフルネームは{0}", b.GetType().FullName);
    }
}
