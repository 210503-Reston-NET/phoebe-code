using System.Collections.Generic;
using RRModels;
using System.IO; // For the File IO
using System.Text.Json; // Json serialization (marshalling and unmarshalling)
using System;
using System.Linq;

namespace RRDL
{
    public class repoFile : IRepository
    {
        private const string filePath = "../RRDL/Restaurants.json";    
        private string jsonString;

        public List<Restaurant> GetAllRestaurants()
        {
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Restaurant>();
            }
            return JsonSerializer.Deserialize<List<Restaurant>>(jsonString);
        }
        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            List<Restaurant> restaurantsFromFile = GetAllRestaurants();
            restaurantsFromFile.Add(restaurant);
            jsonString = JsonSerializer.Serialize(restaurantsFromFile);
            File.WriteAllText(filePath, jsonString);
            return restaurant;
        }

        //Boolean CheckRestaurant(Restaurant restaurant);
    }
}