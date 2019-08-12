// Thus source code was not working in Visual Studio 2019 16.3.0 Preview 1.0

#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;

namespace NotNullIfNotNull
{
    class Program
    {
        [return: NotNullIfNotNull("s")]
        public static string? MyNotNullIfNotNull(string? s)
        {
            return s;
        }

        public static void WorkWithString(string? s)
        {
            var possiblyNullString = MyNotNullIfNotNull(s);
            Console.WriteLine(possiblyNullString.Length); // Warning: Dereference of a possibly null reference

            if (s != null)
            {
                var goodString = MyNotNullIfNotNull(s);
                Console.WriteLine(goodString.Length); // Safe!
            }
        }

        static void Main()
        {
            WorkWithString("Hello");
            WorkWithString(null);
        }
    }
}
