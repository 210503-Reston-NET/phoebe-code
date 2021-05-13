using System;
using RRModels;
using System.Collections.Generic;
using RRBL;

namespace RRUI
{
    public class RestaurantMenu : IMenu
    {
        private IRestaurantBL _restaurantBL;
        private IValidationService _validate;
        public RestaurantMenu(IRestaurantBL restaurantBL, IValidationService validate) 
        {
            this._restaurantBL = restaurantBL;
            this._validate = validate;
        }
        public void Start()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("You are on Restuarant sub-menu!");
                Console.WriteLine("What would like to do?");
                Console.WriteLine("[0] Go back to main menu");
                Console.WriteLine("[1] View a resturant review");
                Console.WriteLine("[2] Add a new resturant");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0" :
                        Console.WriteLine("Go back to the main menu");
                        repeat = false;
                        break;
                    case "1" : 
                    // view a restaruant
                        ViewRestaurants();
                        break;
                    case "2" :
                        // ad new retaurant
                        AddRestaurant();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (repeat);
        }

        private void AddRestaurant()
        {
            string name = _validate.ValidateString("Enter the restaurant name:");
            string city = _validate.ValidateString("Enter city");
            string state = _validate.ValidateString("Enter a state");
            try
            {
                Restaurant newRestaurant = new Restaurant(name, city, state);
                // ToDo : store created resturant -> BL -> DL
                Restaurant createdRestaurant = _restaurantBL.AddRestaurant(newRestaurant);
                Console.WriteLine("Restaurant is created");
                Console.WriteLine(createdRestaurant.ToString());
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
        }

        private void ViewRestaurants()
        {
            List<Restaurant> restaurants = _restaurantBL.GetAllRestaurants();
            Action<Object> print = o => Console.WriteLine(o.ToString());
            if (restaurants.Count == 0) Console.WriteLine("No restaurants :< You should add some");
            else
            {
                restaurants.ForEach(print);
            }
        }
    }
}