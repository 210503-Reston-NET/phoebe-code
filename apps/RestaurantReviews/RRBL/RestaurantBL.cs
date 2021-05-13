using System.Collections.Generic;
using RRModels;
using RRDL;
using System;

namespace RRBL
{
    /// <summary>
    ///  Business logic class for the restaruant model
    /// </summary>
    public class RestaurantBL : IRestaurantBL
    {
        private IRepository _repo;
        //Todo: Implement GetAllRestaurants()
        public RestaurantBL(IRepository repo)
        {
            this._repo = repo;
        }

        public Restaurant AddRestaurant(Restaurant restaurant) {
            // ToDo: check if restaurant already existed
            // if (_repo.CheckRestaurant(restaurant))
            // {
            //     throw new Exception("Resturant is already exists");
            // }
            return _repo.AddRestaurant(restaurant);
        }
        public List<Restaurant> GetAllRestaurants()
        {
            return _repo.GetAllRestaurants();
        }
    }
}