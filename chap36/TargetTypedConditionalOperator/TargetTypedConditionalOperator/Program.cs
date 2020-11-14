using System;

class A { };
class B: A { };

class Program
{
    static void Main()
    {
        var b = true;
        int? x = b ? 1 : null;
        A y = new A() ?? new B();
        Console.WriteLine($"{x} {y}");
    }
}
