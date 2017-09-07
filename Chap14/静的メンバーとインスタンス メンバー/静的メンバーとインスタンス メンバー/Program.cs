using System;

class Program
{
    private int instanceField;
    private static int staticField;
    static void Main(string[] args)
    {
        var a = new Program();
        a.instanceField = 123;
        var b = new Program();
        b.instanceField = 456;
        Program.staticField = 789;
        Console.WriteLine(a.instanceField);
        Console.WriteLine(b.instanceField);
        Console.WriteLine(Program.staticField);
    }
}
