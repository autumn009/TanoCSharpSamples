using System;

class A
    {
        public A() => Console.WriteLine("Constructed!");

        ~A() => Console.Error.WriteLine("Finalized!");

        public string MyProp
        {
            get => "get it!";
            set => Console.WriteLine("set it!");
        }
    }

class Program
{
    static void Main(string[] args)
    {
        var a = new A();
        Console.WriteLine(a.MyProp);
        a.MyProp = "new value";
    }
}
