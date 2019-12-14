using System;
using System.Collections;
using System.Net.Http;
using System.IO;
namespace csharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            try {
                HttpClient client = new HttpClient();
                string body = client.GetStringAsync("http://www.google.com").Result;
                FileInfo fileInfo = new FileInfo("google.html");
                StreamWriter sr = new StreamWriter(fileInfo.Create());
                sr.WriteLine(body);
                sr.Close();
                client.Dispose();
            } catch (HttpRequestException e) {
                Console.WriteLine(e);
            }
        }
    }
}
