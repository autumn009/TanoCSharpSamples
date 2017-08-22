using System;

class Program
{
    static void Main(string[] args)
    {
        System.Func<int, int> del = x => x + 1;
        System.Linq.Expressions.Expression<Func<int, int>> exp = x => x + 1;
    }
}

