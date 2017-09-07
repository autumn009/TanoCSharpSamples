using System;

public class Program
{
    public static void Main(string[] args)
    {
        var now = DateTime.Now.ToUniversalTime();
        foreach (var item in TimeZoneInfo.GetSystemTimeZones())
        {
            Console.WriteLine("{0}では{1}", item.DisplayName, TimeZoneInfo.ConvertTimeFromUtc(now, item));
        }
    }
}
