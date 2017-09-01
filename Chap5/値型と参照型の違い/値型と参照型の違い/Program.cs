using System;

public class A
{
    public int X;
}

class Program
{
    static void Main(string[] args)
    {
        // class A
        A a1 = new A(); // 変数を宣言
        a1.X = 123; // 123を入れる
        A a2 = a1;  // 複製を作る
        a1.X = 456; // 456を入れる
        Console.WriteLine("a1.X={0}", a1.X);
        Console.WriteLine("a2.X={0}", a2.X);
        // int
        int b1; // 変数を宣言
        b1 = 123; // 123を入れる
        int b2 = b1;  // 複製を作る
        b1 = 456; // 456を入れる
        Console.WriteLine("b1={0}", b1);
        Console.WriteLine("b2={0}", b2);
    }
}
