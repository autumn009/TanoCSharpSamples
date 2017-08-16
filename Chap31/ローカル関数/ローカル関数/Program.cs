using System;
class Program
{
    static void Main(string[] args)
    {
        sub();
        sub();
        Console.WriteLine("大事なことなので2回言いました。");

        void sub()
        {
            Console.WriteLine("大事なこと");
        }
    }
}
