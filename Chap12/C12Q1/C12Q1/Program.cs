using System;

class X
{
    private X(int x)
    {
        Console.WriteLine("オブジェクトが作成されました。{0}", x);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new X(123);
    }
}
