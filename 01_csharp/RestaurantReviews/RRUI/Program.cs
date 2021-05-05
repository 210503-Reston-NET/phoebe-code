using System;
using RRModels;
using System.Collections.Generic;

namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant sushiLand = new Restaurant("sushi land", "Seattle", "WA");
            sushiLand.Reviews = new List<Review>
            {
                new Review{
                    Rating = 5,
                    Description = "best sushi"
                },
                new Review{
                    Rating = 4,
                    Description = "good sushi"
                }
            };
            Console.WriteLine(sushiLand.ToString());
            foreach (Review review in sushiLand.Reviews)
            {
                Console.WriteLine(review.ToString());
            }
        }
    }
}
