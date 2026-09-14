using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static List<string> urls = new List<string>(3)
    {
        "https://www.cnn.com",
        "https://www.amazon.com",
        "https://www.programmingadvices.com"
    };

    static void Main()
    {

        // Use Parallel.ForEach to download the web pages concurrently
        Parallel.ForEach(urls, url =>
        {
            DownloadContent(url);

        });

        Console.WriteLine("Done!");
        Console.ReadKey();
    }

    static void DownloadContent(string url)
    {
        string content;

        using (WebClient client = new WebClient())
        {
            // Simulate some work by adding a delay
            Thread.Sleep(100);

            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
            client.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");

            // Download the content of the web page
            content = client.DownloadString(url);
        }

        Console.WriteLine($"{url}: {content.Length} characters downloaded");
    }
}