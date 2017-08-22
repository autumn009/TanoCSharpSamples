using System;

class Program
{
    static void Main(string[] args)
    {
        goto mylabel;
        {
            mylabel: Console.WriteLine("Jumped!");
        }
    }
}
