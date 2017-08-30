using System;

class Program
{
    static void Main(string[] args)
    {
        string message = "first";
        Action a = () =>
        {
            Console.WriteLine(message);
        };
        message = "second";
        a();
        message = "third";
    }
}
