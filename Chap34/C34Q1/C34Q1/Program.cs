using System;

class A<T> where T : unmanaged
{
    public static void DoIt() => Console.WriteLine(typeof(T).Name);
}

class Program
{
    static void Main()
    {
        A<int>.DoIt();
        A<string>.DoIt();
        A<Int32>.DoIt();
        A<DateTime>.DoIt();
    }
}
