using System;

class Program
{
    static void Main()
    {
        int a = 120;
        string b = $@"\{a}-";
        string c = @$"\{a}-";
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
