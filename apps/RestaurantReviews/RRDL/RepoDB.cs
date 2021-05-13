using System.Collections.Generic;
using Model = RRModels;
using Entity = RRDL.Entities;
using System.Linq;
using RRModels;

namespace RRDL
{
    public class RepoDB : IRepository
    {
        private Entity.RestaurantDBContext _context;

        public RepoDB(Entity.RestaurantDBContext context)
        {
            _context = context;
        }
        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            throw new System.NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _context.Restaurants
            .Select
            (
                resto => new Model.Restaurant(resto.Name, resto.City, resto.State)
            ).ToList();
        }
    }
}