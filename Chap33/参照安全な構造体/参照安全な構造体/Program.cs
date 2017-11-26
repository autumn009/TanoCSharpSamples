using System;

ref struct A {
    internal int TheValue { get; set; }
}

ref struct B
{
    internal A TheStruct { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var x = new B();
        Console.WriteLine(x.TheStruct.TheValue);
    }
}
