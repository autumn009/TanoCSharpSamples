using System;

readonly struct Example
{
    internal readonly int MyField1;
    // 許可されない
    // internal int MyField2;
    public int MyProperty1 { get; }
    // 許可されない
    // public int MyProperty2 { get; set; }
    internal void Sub()
    {
        int x = 123;
        // 許可されない
        // MyField1 = 123;
    }
    internal Example(int x, int y)
    {
        MyField1 = x;
        MyProperty1 = y;
    }
}


class Program
{
    static void Main(string[] args)
    {
        var e = new Example(1,2);
        e.Sub();
        Console.WriteLine(e.MyField1);
        Console.WriteLine(e.MyProperty1);
    }
}