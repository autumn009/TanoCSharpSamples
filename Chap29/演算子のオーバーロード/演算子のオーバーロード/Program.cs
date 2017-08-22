using System;

class NameNumber
{
    public string Name;
    public int ToNumber()
    {
        if (Name == "One") return 1;
        if (Name == "Two") return 2;
        if (Name == "Three") return 3;
        throw new ApplicationException();
    }
    public static NameNumber FromInt(int n)
    {
        string name;
        switch (n)
        {
            case 1: name = "One"; break;
            case 2: name = "Two"; break;
            case 3: name = "Three"; break;
            default:
                throw new ApplicationException();
        }
        return new NameNumber() { Name = name };
    }
    public override string ToString()
    {
        return Name;
    }
    public static NameNumber operator +(NameNumber x, NameNumber y)
    {
        return FromInt(x.ToNumber() + y.ToNumber());
    }
};

class Program
{
    static void Main(string[] args)
    {
        var a = new NameNumber() { Name = "One" };
        var b = new NameNumber() { Name = "Two" };
        Console.WriteLine(a + b);
    }
}
