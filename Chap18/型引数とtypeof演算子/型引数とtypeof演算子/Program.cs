using System;

class Program
{
    private static void yourType<T>()
    {
        Type t = typeof(T);
        Console.WriteLine("Tは{0}型です。", t.FullName);
        if (t.IsValueType) Console.WriteLine("Tは値型です"); else Console.WriteLine("Tは参照型です");
    }

    static void Main(string[] args)
    {
        yourType<int>();
        yourType<string>();
    }
}
