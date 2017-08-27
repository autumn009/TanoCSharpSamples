using System;

class Program
{
    static void Main(string[] args)
    {
        Action a = null;
        a();
        Console.WriteLine("Done:{0}", a);
    }
}
