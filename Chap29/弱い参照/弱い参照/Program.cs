using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        const int size1 = 10000;
        const int size2 = 10000000;
        var list = new List<object>();
        for (int i = 0; i < size1; i++)
        {
            var ar = new byte[size2];
            list.Add(ar);
        }
    }
}
