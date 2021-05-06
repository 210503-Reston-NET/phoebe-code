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
                Console.WriteLine("[0] View a resturant review");
                Console.WriteLine("[1] Exit the program");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0" : 
                        //ToDo: access data from BL and DL layer
                        submenu = new RestaurantMenu(new RestaurantBL(new RepoSC()));
                        submenu.Start();
                        break;
                    case "1" :
                        Console.WriteLine("Thanks for using the system. Goodbye");
                        repeat = false;
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