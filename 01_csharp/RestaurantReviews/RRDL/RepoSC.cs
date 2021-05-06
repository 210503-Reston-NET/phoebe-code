using System.Collections.Generic;
using RRModels;
namespace RRDL
{
    public class RepoSC : IRepository
    {
        public List<Restaurant> GetAllRestaurants()
        {
            //ToDo: get data from a static collection storage
            return RRSCStorage.Restaurants;
        }
    }
}