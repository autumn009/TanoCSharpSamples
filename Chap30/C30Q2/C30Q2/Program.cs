using System;

class A
{
    public string Name { get; } = "My Name";
}

class Program
{
    static void Main(string[] args)
    {
        var a = new A();
        Console.WriteLine(a.Name);
    }
}
