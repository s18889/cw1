using System;
using System.Net.Http;

namespace Cwiczenia1
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new HttpClient();

            int g = 0;

            for(int i = 0; i < 10; i++)
            {
                g += i;
            }

            Console.WriteLine("Hello World!");
            
        }
    }
}
