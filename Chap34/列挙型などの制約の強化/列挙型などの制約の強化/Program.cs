using System;

class A<T> where T : System.Enum
{
    public static void DoIt()
    {
        foreach (var item in Enum.GetNames(typeof(T))) Console.Write(item);
    }
}

enum E { X, Y, Z }

class Program
{
    static void Main() => A<E>.DoIt();
}

