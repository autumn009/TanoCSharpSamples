using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        int types = 0, methods = 0;
        foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        {
            foreach (Type t in asm.GetTypes())
            {
                types++;
                foreach (var item in t.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
                {
                    methods++;
                }
            }
        }
        Console.WriteLine("このアプリケーションドメインには{0}個の型に{1}個のメソッドがあります。", types, methods);
    }
}
