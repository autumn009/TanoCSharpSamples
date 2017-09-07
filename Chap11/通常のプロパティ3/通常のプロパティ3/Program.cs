using System;

class PercentClass
{
    private int myValue;
    public int Percent
    {
        get { return myValue; }
        set
        {
            if (value < 0 || value > 100) throw new ArgumentException("Persontプロパティの値は0から100です。");
            myValue = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new PercentClass();
        a.Percent = 123;
        Console.WriteLine(a.Percent);
    }
}
