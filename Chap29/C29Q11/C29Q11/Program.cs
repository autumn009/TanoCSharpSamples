using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        switch (a)
        {
            case 1:
                Console.Write(a);
                if (a++ == 3) goto default;
                else goto case 1;
            default:
                break;
        }
    }
}
