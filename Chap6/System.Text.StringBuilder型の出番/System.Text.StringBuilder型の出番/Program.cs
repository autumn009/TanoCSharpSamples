using System;
using System.Text;

class Program
{
    private static void run(Action act)
    {
        DateTime start = DateTime.Now;
        for (int i = 0; i < 10000000; i++)
        {
            act();
        }
        Console.WriteLine(DateTime.Now - start);
    }


    static void Main(string[] args)
    {
        int count=0;
        string b = "B";
        string c = "B";
        string d = "B";
        string e = "B";
        string f = "B";
        string g = "B";
        string h = "B";
        string i = "B";
        Console.WriteLine("1つの式");
        run(() => {
            string a = b + c + d + e + f + g + h + i;
            count += a.Length;
        });
        Console.WriteLine("複数式");
        run(() => {
            string a = b;
            a = a + c;
            a = a + d;
            a = a + e;
            a = a + f;
            a = a + g;
            a = a + h;
            a = a + i;
            count += a.Length;
        });
        Console.WriteLine("StringBuilder");
        run(() => {
            var a = new StringBuilder();
            a.Append(b);
            a.Append(c);
            a.Append(d);
            a.Append(e);
            a.Append(f);
            a.Append(g);
            a.Append(h);
            a.Append(i);
            count += a.Length;
        });
    }
}
