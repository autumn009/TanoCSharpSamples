using System;

class X
{
    public X(int x)
    {
        Console.WriteLine("コンストラクタその1");
    }
    public X()
    {
        Console.WriteLine("コンストラクタその2");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new X();
    }
}
