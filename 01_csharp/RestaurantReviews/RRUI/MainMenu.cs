using System;
using RRModels;
using System.Collections.Generic;

namespace RRUI
{
    public class MainMenu : IMenu
    {
        public void Start()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome to my Restaurant Review Application!");
                Console.WriteLine("What would like to do?");
                Console.WriteLine("[0] View a resturant review");
                Console.WriteLine("[1] Exit the program");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0" : 
                    // view a restaruant
                        ViewRestaurant();
                        break;
                    case "1" :
                        Console.WriteLine("Thanks for using the system. Goodbye");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Please input a valid option");
                        break;
                }
            }
            while (repeat);
        }
        private void ViewRestaurant()
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