using System;
using RRModels;
using System.Collections.Generic;

namespace RRUI
{
    public class RestaurantMenu : IMenu
    {
        public void Start()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome to my Restaurant Review Application!");
                Console.WriteLine("What would like to do?");
                Console.WriteLine("[0] View a resturant review");
                Console.WriteLine("[1] Go back to main menu");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0" : 
                    // view a restaruant
                        ViewRestaurant();
                        break;
                    case "1" :
                        Console.WriteLine("Go back to the main menu");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (repeat);
        }
        private void ViewRestaurant()
        {   
            // ToDo: Remove the hardcoded restaurant and refer to a stored restaurant
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