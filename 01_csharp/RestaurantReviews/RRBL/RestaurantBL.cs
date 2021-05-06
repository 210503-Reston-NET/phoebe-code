using System.Collections.Generic;
using RRModels;
using RRDL;
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
        public List<Restaurant> GetAllRestaurants()
        {
            return _repo.GetAllRestaurants();
        }
    }
}