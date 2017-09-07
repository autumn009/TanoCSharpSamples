using System;

class Report
{
    public Report(string s)
    {
        Console.WriteLine(s);
    }
}

class X
{
    public Report N = new Report("field");
    public X()
    {
        N = new Report("constructor");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var x = new X() { N = new Report("object initialize") };
    }
}
