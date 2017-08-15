using System;

class A
{
    public string CreatedDateTime { get; }
    public A()
    {
        CreatedDateTime = DateTime.Now.ToString();
    }
}


class Program
{
    static void Main(string[] args)
    {
        var a = new A();
        Console.WriteLine(a.CreatedDateTime);
    }
}
