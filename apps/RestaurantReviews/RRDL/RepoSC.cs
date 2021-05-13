using System.Collections.Generic;
using RRModels;
using System.Linq;
using System;

namespace RRDL
{
    public class RepoSC : IRepository
    {
        public Restaurant AddRestaurant(Restaurant restaurant)
        {   
            // save restaurant to storage
            RRSCStorage.Restaurants.Add(restaurant);
            return restaurant;
        }

        public Boolean CheckRestaurant(Restaurant restaurant) 
        {
            //return RRSCStorage.Restaurants.FirstOrDefault(resto => resto.Equals(restaurant));
            return RRSCStorage.Restaurants.Contains(restaurant);
        }
        public List<Restaurant> GetAllRestaurants()
        {
            return RRSCStorage.Restaurants;
        }
    }
}