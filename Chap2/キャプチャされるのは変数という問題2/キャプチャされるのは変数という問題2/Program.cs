using System;

class Program
{
    static void Main(string[] args)
    {
        int i1 = 1;
        Action a1 = () => Console.WriteLine(i1);
        int i2 = i1 + 1;
        Action a2 = () => Console.WriteLine(i2);
        a1();
        a2();
    }
}
