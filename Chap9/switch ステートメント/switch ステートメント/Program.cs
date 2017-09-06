using System;

public class Program
{
    static void Main(string[] args)
    {
        string s = "two";
        switch (s)
        {
            case "one":
                Console.WriteLine("1");
                break;
            case "two":
                Console.WriteLine("2");
                break;
            default:
                Console.WriteLine("other value");
                break;
        }
    }
}
