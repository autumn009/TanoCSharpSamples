using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

class Program
{
    const string str = @"Alpha
Beta
Gamma
";
    static async IAsyncEnumerable<string> sub()
    {
        var reader = new StringReader(str);
        for (; ; )
        {
            var s = await reader.ReadLineAsync();
            if (s == null) break;
            yield return s;
        }
    }

    static async Task Main()
    {
        await foreach (var item in sub())
        {
            Console.WriteLine(item);
        }
    }
}
