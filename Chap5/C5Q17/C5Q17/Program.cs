using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "たろう";
        {
            string name = "じろう";
            name = "さぶろう";
        }
        Console.WriteLine(name);
    }
}
