using System;

class Program
{
    static void sub(object o)
    {
        Console.WriteLine(o switch {
        string s when s.Length < 3 => s.ToUpper(),
        string s => s.ToLower(),
        _ => "It's other"
        });
    }


    static void Main()
    {
        sub("Hello");
        sub("Ok");
        sub(null);
    }
}
