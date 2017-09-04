using System;

class Store<T>
{
    public T Value1 { get; set; }
    public T Value2 { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new Store<int>();
        var b = new Store<string>();
        a.Value1 = 123;
        a.Value2 = 456;
        b.Value1 = "Hello";
        b.Value2 = "World";
        Console.WriteLine(a.Value1 + a.Value2);
        Console.WriteLine(b.Value1 + b.Value2);
    }
}
