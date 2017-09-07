using System;

class X
{
    private string[] ar = new string[100];
    public string this[int i]
    {
        get
        {
            return ar[i];
        }
        set
        {
            ar[i] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new X();
        a[51] = "AREA";
        a[7] = "ULTRA";
        Console.WriteLine(a[7]);
        Console.WriteLine(a[51]);
    }
}
