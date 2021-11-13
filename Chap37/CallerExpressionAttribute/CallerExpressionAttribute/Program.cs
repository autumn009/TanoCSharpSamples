using System;
using System.Runtime.CompilerServices;

CalcAndReport(1.23 * 4.56);
CalcAndReport((1 + 2) * 3);
CalcAndReport(Math.PI);
CalcAndReport("Hello " + "World!");

void CalcAndReport<T>(T argument, [CallerArgumentExpression("argument")] string? argumentExpression = null)
{
    Console.WriteLine($"{argumentExpression} = {argument}");
}
