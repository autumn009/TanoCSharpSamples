using System;

class MyString : string
{
    public override string ToString()
    {
        return "このインスタンスに含まれる文字列は" + base.ToString() + "です。";
    }
}

class Program
{
    static void Main(string[] args)
    {
    }
}
