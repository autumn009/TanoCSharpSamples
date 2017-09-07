using System;

class MyClass
{
    public static int X { get; private set; }
    static MyClass()
    {
        Console.WriteLine("Initializing");
        X = 4949;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start Main");
        Console.WriteLine(MyClass.X);
        Console.WriteLine("End Main");
    }
}
