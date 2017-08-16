using System;
class Program
{
    static void Main(string[] args)
    {
        object[] array = { 1, "abc", 2, "cde" };
        foreach (var item in array)
        {
            if (item is int n)
                Console.WriteLine(n + 1);
            else if (item is string s)
                Console.WriteLine(s.ToUpper());
        }
    }
}
