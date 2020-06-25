using System;

partial class MyClass
{
    internal static partial bool TryParse(string s, out int i);
}

partial class MyClass
{
    internal static partial bool TryParse(string s, out int i)
    {
        return int.TryParse(s, out i);
    }
}

class Program
{
    static void Main()
    {
        int a;
        MyClass.TryParse("1233", out a);
        Console.WriteLine(a + 1);
    }
}
