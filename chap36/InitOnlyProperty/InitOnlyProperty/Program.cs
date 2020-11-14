using System;

class X
{
    public int MyProperty1 { get; set; }
    public int MyProperty2 { get; init; }
}

class Program
{
    static void Main()
    {
        var x = new X() { MyProperty1 = 123, MyProperty2 = 456 };
        x.MyProperty1 = 0;
        //x.MyProperty2 = 0;    // ←できない
        Console.WriteLine($"{x.MyProperty1} {x.MyProperty2}");
    }
}