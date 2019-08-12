// Thus source code was not working in Visual Studio 2019 16.3.0 Preview 1.0

#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    [DoesNotReturn]
    private static void ReportError(bool errorType)
    {
        if (errorType)
        {
            throw new ArgumentException("Wrong Argument!");
        }
        else
        {
            throw new DivideByZeroException("It was ZERO!");
        }
    }

    static void Main()
    {
        string s;
        ReportError(false);
        Console.WriteLine(s);
    }
}
