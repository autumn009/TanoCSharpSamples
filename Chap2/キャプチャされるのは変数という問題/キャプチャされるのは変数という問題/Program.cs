using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        Action a1 = () => Console.WriteLine(i);
        i = i + 1;
        Action a2 = () => Console.WriteLine(i);
        a1();
        a2();
    }
}
