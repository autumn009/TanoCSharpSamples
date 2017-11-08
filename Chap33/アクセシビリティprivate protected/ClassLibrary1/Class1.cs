using System;

public class Class1
{
    private protected int myProperty1 { get; set; }
}

public class Class2 : Class1
{
    public void Sub()
    {
        Console.WriteLine(myProperty1);
    }
}
