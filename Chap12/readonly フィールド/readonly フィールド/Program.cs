using System;

class A
{
    public readonly int a = 123; // フィールドの初期化式
    public readonly int b;
    public A() // コンストラクタ
    {
        b = 456;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var x = new A();
        Console.WriteLine(x.a);
        Console.WriteLine(x.b);
    }
}
