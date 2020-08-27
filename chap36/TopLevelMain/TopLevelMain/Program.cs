using System;

var t = "Top";
var s = new MyClass();

Console.WriteLine($"{t} {MyMethod()} {s.Statenment()}");

string MyMethod() => "Level";

class MyClass
{
    internal string Statenment() => "Statement";
}

