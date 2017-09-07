using System;

class Program
{
    private static void showMeMessage(object o)
    {
        string msg = o as string;
        if (msg != null) Console.WriteLine(msg);
    }

    static void Main(string[] args)
    {
        showMeMessage(123);
        showMeMessage("456");
    }
}
