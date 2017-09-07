using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        object[] array = { };
        var found = array.FirstOrDefault();
        if (found == null) Console.WriteLine("発見できませんでした。");
        else Console.WriteLine(found.ToString());
    }
}
