using System;

public class Program
{
    static void Main(string[] args)
    {
        string s = "one";
        switch (s)
        {
            case "one":
            case "two":
                Console.WriteLine("1 or 2");
                break;
            default:
                Console.WriteLine("other value");
                break;
        }
    }
}
