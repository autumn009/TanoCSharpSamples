using System;
class Program
{
    private static Action sub()
    {
        int a = 123;
        return inner;

        void inner()
        {
            Console.WriteLine(a);
        }
    }


    static void Main(string[] args)
    {
        var act = sub();
        act();
        act();
    }
}
