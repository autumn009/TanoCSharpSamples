using System;

static partial class MyClass
{
    public static void OutputIt()
    {
        Console.WriteLine("Your number is {0}", superNumber);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass.OutputIt();
    }
}
