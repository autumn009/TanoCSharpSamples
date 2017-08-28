using System;

class Program
{
    static void Main(string[] args)
    {
        var a = new Action[10];
        for (int i = 0; i < 10; i++)
        {
            a[i] = () => Console.WriteLine(i);
        }
        foreach (var item in a)
        {
            item();
        }
    }
}
