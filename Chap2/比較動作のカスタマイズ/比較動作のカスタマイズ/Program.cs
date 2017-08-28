using System;

class A
{
    internal string str;
    public static bool operator ==(A a, A b)
    {
        if (Object.ReferenceEquals(a, b)) return true;
        if (((object)a == null) || ((object)b == null)) return false;
        return a.str.ToLower() == b.str.ToLower();
    }

    public static bool operator !=(A a, A b)
    {
        return !(a == b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        A a = new A() { str = "Hello!" };
        A b = new A() { str = "HELLO!" };
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
    }
}
