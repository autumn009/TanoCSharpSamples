using System;
using System.Reflection;

class Program
{
    private static void sample(Assembly assem)
    {
        Console.WriteLine(assem.FullName);
    }

    static void Main(string[] args)
    {
        sample(Assembly.GetExecutingAssembly());
        sample(Assembly.GetEntryAssembly());
        sample(Assembly.GetCallingAssembly());
        sample(Assembly.GetAssembly(typeof(Program)));
        Console.WriteLine("現在のAppDomainにロードされているアセンブリの数は{0}です。", AppDomain.CurrentDomain.GetAssemblies().Length);
    }
}
