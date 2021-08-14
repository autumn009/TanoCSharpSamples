// See https://aka.ms/new-console-template for more information
A a = new A();
a.Sub();

struct A
{
    internal void Sub()
    {
        Console.WriteLine("Hello, World!");
    }
    public A()
    {
        Console.WriteLine("Constructed!");
    }
}