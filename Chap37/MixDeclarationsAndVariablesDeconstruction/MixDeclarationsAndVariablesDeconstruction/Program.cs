using System;

int b;
(var a, b) = f();
Console.WriteLine(a);
Console.WriteLine(b);

(int, int) f()
{
    return (1, 2);
}
