using System;

class Store<T1, T2>
{
    public T1 Value1 { get; set; }
    public T2 Value2 { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new Store<int, string>();
        var b = new Store<string, int>();
        a.Value1 = 123;
        a.Value2 = "Hello";
        b.Value1 = "World";
        b.Value2 = 123;
        Console.WriteLine(a.Value1 + b.Value2);
        Console.WriteLine(a.Value2 + b.Value1);
    }
}
