using System;
using System.Reflection;

class A { }

class Program
{
    static void Main(string[] args)
    {
        var asm = Assembly.GetExecutingAssembly();
        foreach (Type t in asm.GetTypes())
        {
            Console.WriteLine("{0}型には以下のメソッドがあります。", t.Name);
            foreach (var item in t.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
            {
                Console.WriteLine("・{0}", item.Name);
            }
        }
    }
}
