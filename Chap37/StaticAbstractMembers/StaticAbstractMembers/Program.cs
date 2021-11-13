using System;

Sub<B>();

void Sub<T>() where T: IA
{
    T.MyMethod();
}

interface IA
{
    static abstract void MyMethod();
}
class B : IA
{
    public static void MyMethod()
    {
        Console.WriteLine("Hello, World!");
    }
}
