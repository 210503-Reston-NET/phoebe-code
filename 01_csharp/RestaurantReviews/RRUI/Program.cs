using System;
using RRModels;

namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Restaurant sushiLand = new Restaurant("sushi land", "Seattle", "WA");
            Console.WriteLine(sushiLand.ToString());
        }
    }
}
