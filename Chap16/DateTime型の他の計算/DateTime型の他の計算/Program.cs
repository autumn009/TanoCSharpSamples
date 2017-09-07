    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var d1 = DateTime.Now.AddHours(2.0);
            var d2 = DateTime.Now.AddDays(3.0);
            Console.WriteLine("2時間後は{0}", d1);
            Console.WriteLine("3日後は{0}", d2);
        }
    }
