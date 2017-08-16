using System;
using System.Collections.Generic;
using System.Linq;

namespace タプル名の推論
{
    class A
    {
        public int f1, f2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<A>();
            list.Add(new A() { f1 = 123, f2 = 1 });
            list.Add(new A() { f1 = 456, f2 = 2 });
            var result = list.Select(c => (c.f1, c.f2)).Where(t => t.f2 == 1);
            foreach (var item in result)
            {
                Console.WriteLine("{0},{1}",item.f1, item.f2);
            }
        }
    }
}
