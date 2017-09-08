using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        IComparable s = "Hello!";
        Console.WriteLine(s is ICloneable);
        Console.WriteLine(s is IConvertible);
        Console.WriteLine(s is IEnumerable);
        Console.WriteLine(s is IComparable<string>);
        Console.WriteLine(s is IEnumerable<char>);
        Console.WriteLine(s is IEquatable<string>);
    }
}
