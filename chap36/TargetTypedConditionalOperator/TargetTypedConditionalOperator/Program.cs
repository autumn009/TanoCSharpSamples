using System;

class A { };
class B: A { };
class C : A { };

class Program
{
    static void Main()
    {
        var b = false;
        int? x = b ? 1 : null;
        A y = new B() ?? new C();
        Console.WriteLine($"{x} {y}");
    }
}
