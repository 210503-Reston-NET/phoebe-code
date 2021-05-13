using System;
using RRModels;
using System.Collections.Generic;
using RRBL;
using RRDL;

namespace RRUI
{
    public class MainMenu : IMenu
    {
        private IMenu submenu;
        public void Start()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome to my Restaurant Review Application!");
                Console.WriteLine("What would like to do?");
                Console.WriteLine("[0] Exit the program");
                Console.WriteLine("[1] CRUD a resturant"); 
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0" :
                        Console.WriteLine("Thanks for using the system. Goodbye");
                        repeat = false;
                        break;
                    case "1" : 
                        //submenu = new RestaurantMenu(new RestaurantBL(new repoFile()), (new ValidationService()));
                        submenu = MenuFactory.GetMenu("restaurant");
                        submenu.Start();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (repeat);
        }
    }
}