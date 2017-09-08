using System;

class MySpecialAttribute : Attribute
{
}

class Program
{
    [MySpecial]
    public static void A()
    {
        Console.WriteLine("in Program.A");
    }
    [MySpecial]
    public static void B()
    {
        Console.WriteLine("in Program.B");
    }
    public static void C()
    {
        Console.WriteLine("in Program.C");
    }
    static void Main(string[] args)
    {
        foreach (var item in typeof(Program).GetMethods())
        {
            object[] objs = item.GetCustomAttributes(typeof(MySpecialAttribute), true);
            if (objs != null && objs.Length > 0) item.Invoke(null, null);
        }
    }
}
