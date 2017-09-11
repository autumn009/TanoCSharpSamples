using System;

class Program
{
    static void Main(string[] args)
    {
        // stringは参照型
        string a1 = "123"; // 変数を宣言
        string a2 = a1;  // 複製を作る
        a1 = "456"; // 456を入れる
        Console.WriteLine("a1={0}", a1);
        Console.WriteLine("a2={0}", a2);
        // intは値型
        int b1 = 123; // 変数を宣言
        int b2 = b1;  // 複製を作る
        b1 = 456; // 456を入れる
        Console.WriteLine("b1={0}", b1);
        Console.WriteLine("b2={0}", b2);
    }
}
