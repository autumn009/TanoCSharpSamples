global using static System.Console;
global using System.Linq;

class Class1
{
    internal static void Sub()
    {
        WriteLine($"Sub {string.Join(',',Enumerable.Range(0,3))}");
    }
}
