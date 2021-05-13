using RRBL;
using RRDL;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RRDL.Entities;

namespace RRUI
{
    public class MenuFactory
    {    
        public static IMenu GetMenu(string menuType) 
        {
            //getting configurations from a config file
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            //setting up my db connections
            string connectionString = configuration.GetConnectionString("RestaurantDB");
            //we're building the dbcontext using the constructor that takes in options, we're setting the connection
            //string outside the context def'n
            DbContextOptions<RestaurantDBContext> options = new DbContextOptionsBuilder<RestaurantDBContext>()
            .UseSqlServer(connectionString)
            .Options;
            //passing the options we just built
            var context = new RestaurantDBContext(options);

            //IRestaurantBL deps = new RestaurantBL(new repoFile());
            IRestaurantBL deps = new RestaurantBL(new RepoDB(context));


            switch(menuType.ToLower())
            {
                case "main":
                    return new MainMenu();
                case "restaurant":
                    return new RestaurantMenu(deps, new ValidationService());
                default:
                    return null;
            }
        }
    }
}