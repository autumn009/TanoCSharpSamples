using System;

MyClass c = new MyClass();
if ((c != null && c.MyMethod(out object obj1)))
{
    // obj1は初期化済みと見抜ける
    Console.WriteLine(obj1.ToString());
}
if ((c != null && c.MyMethod(out object obj2)) == true)
{
    // obj2は初期化済みと見抜けない→見抜ける
    Console.WriteLine(obj2.ToString());
}

public class MyClass
{
    public bool MyMethod(out object obj)
    {
        obj = "hello";
        return true;
    }
}
