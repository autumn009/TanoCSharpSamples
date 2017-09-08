using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        var assem = Assembly.GetExecutingAssembly();
        Console.WriteLine("アセンブリの名前は{0}", assem.FullName);
        Console.WriteLine("アセンブリのLocationは{0}", assem.Location);
        Console.WriteLine("含まれているモジュール数は{0}", assem.GetModules().Length);
        foreach (var item in assem.GetModules())
        {
            Console.WriteLine("モジュールの名前は{0}", item.FullyQualifiedName);
        }
    }
}
