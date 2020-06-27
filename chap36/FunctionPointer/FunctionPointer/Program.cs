using System;

unsafe class Program
{
    public static void IndirectCall(delegate*<void> fp)
    {
        fp();
    }

    static void MyMethod()
    {
        Console.WriteLine("I'm my method!");
    }
    static void Main()
    {
        IndirectCall(&MyMethod);
    }
}

