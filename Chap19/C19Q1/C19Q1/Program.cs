using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        var client = new WebClient();
        client.DownloadDataAsync(new Uri("http://www.piedey.co.jp/"));
        client.DownloadDataCompleted += client_DownloadDataCompleted;
    }

    static void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
    {
        Console.WriteLine("Completed!");
    }
}
