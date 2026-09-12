using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static async Task Main(string[] args)
    {
        Task<int> taskRes = GetDataAsync("https://google.com/");

        Console.WriteLine("Doing something else.......");

        var res = await taskRes; // wait and don't complete execution while task return result.

        Console.WriteLine($"Done result is: {res}");

        Console.ReadLine();
    }

    static async Task<int> GetDataAsync(string url)
    {
        HttpClient httpClient = new HttpClient();
        Console.WriteLine("I will go do something else while this task finish!\n");

        //await Task.Delay(2000);// go do something else while this task finish!

        string pageStr = await httpClient.GetStringAsync(url);// go do something else while this task finish!

        Console.WriteLine("Finally! I am finished.");

        var res = pageStr.Length;

        return res;
    }
}
