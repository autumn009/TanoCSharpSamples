using System;

class Program
{
    static void Main(string[] args)
    {
        object o = new object();
        lock (o)
        {
            lock (o)
            {
                Console.WriteLine("Hello Multitask World!");
            }
        }
    }
}

