using System;

class Program
{
    static void Main()
    {
        Span<int> numbers = stackalloc[] { 1, 3, 5, 7 };
        var index = numbers.IndexOfAny(stackalloc[] { 4, 5, 6 });
        Console.WriteLine(index);
    }
}
