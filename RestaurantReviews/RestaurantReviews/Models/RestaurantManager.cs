using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class RestaurantManager
    {
        RestaurantRepository restaurantRepository = new RestaurantRepository();

        public List<Restaurant> GetAllRestaurants()
        {
            return restaurantRepository.GetRestuarants();
        }
    }
}
