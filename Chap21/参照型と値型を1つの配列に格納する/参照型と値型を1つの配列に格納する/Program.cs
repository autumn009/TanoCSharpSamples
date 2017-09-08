using System;

class Program
{
    static void Main(string[] args)
    {
        object[] array =
        {
            1,"2",3.0
        };
        foreach (var item in array) Console.WriteLine(item);
    }
}
