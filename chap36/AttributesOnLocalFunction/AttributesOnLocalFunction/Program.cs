    using System;

    public class SampleAttribute : Attribute
    {
        public SampleAttribute() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LocalFunc(1234);
            static void LocalFunc([Sample] int x)
            {
                Console.WriteLine($"Hello in LocalFunc {x}");
            }
        }
    }
