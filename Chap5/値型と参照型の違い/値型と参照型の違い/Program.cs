using System;

public class MyReferenceType
{
    public int X;
}

public struct MyValueType
{
    public int X;
}

class Program
{
    static void Main(string[] args)
    {
        // class MyreferenceType
        MyReferenceType a1 = new MyReferenceType(); // 変数を宣言
        a1.X = 123; // 123を入れる
        MyReferenceType a2 = a1;  // 複製を作る
        a1.X = 456; // 456を入れる
        Console.WriteLine("a1.X={0}", a1.X);
        Console.WriteLine("a2.X={0}", a2.X);
        // struct MyValueType
        MyValueType b1 = new MyValueType(); // 変数を宣言
        b1.X = 123; // 123を入れる
        MyValueType b2 = b1;  // 複製を作る
        b1.X = 456; // 456を入れる
        Console.WriteLine("b1.X={0}", b1.X);
        Console.WriteLine("b2.X={0}", b2.X);
    }
}
