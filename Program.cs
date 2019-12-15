using System;
using System.Collections;
using System.Net.Http;
using System.IO;
using calculator;
namespace csharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();    
            calculator.sum(20.5 , 9.04);
            calculator.diff(2, -1);
            calculator.div(10.24, -2.35);
            calculator.mult(29 , 1.01);
            calculator.div(20 , 0);
            calculator.printHistories();
            Console.WriteLine(calculator.numOfSums());
            Console.WriteLine(calculator.numOfDiffs());

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
