using System;

class Class3 : Class2
{
    public void Sub2()
    {
        Sub();
        // 以下はコンパイルエラーになる
        // Console.WriteLine(myProperty1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var x = new Class3();
        x.Sub2();
    }
}
