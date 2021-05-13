using System.Collections.Generic;
using RRModels;
using System;

namespace RRDL
{
    public interface IRepository
    {
        List<Restaurant> GetAllRestaurants();
        Restaurant AddRestaurant(Restaurant restaurant);

        //Boolean CheckRestaurant(Restaurant restaurant);
        //Restaurant GetRestaurant(Restaurant restaurant);

    }
}