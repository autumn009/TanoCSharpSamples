using System;

class Program
{
    static void Main()
    {
        int x = 123;
        Func<int> f1 = () => x;
        // A static anonymous function cannot contain a reference to 'x'.
        //Func<int> f2 = static () => x;
        Func<int,int> f3 = static (p) => p;
        Console.WriteLine(f1());
        //Console.WriteLine(f2());
        Console.WriteLine(f3(x));
    }
}
