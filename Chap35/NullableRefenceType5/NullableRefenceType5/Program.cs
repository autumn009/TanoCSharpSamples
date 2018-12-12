using System;
#nullable enable

class Program
{
    private static void sub(ref string s, string n)
    {
        if (int.TryParse(n, out int r)) s += n;
        else s = "ERROR";
    }

    static void Main()
    {
        string s1 = null!;
        sub(ref s1, "ABC");
        Console.WriteLine(s1);
    }
}
