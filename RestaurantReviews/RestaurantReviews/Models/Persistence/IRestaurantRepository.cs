using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public interface IRestaurantRepository
    {

        public List<Restaurant> GetRestuarants();
        
        public Restaurant FindRestaurant(int id);
       
        public int GetNumberOfReviews(int id);
       
        public double GetScoreForRestaurant(int id, string typeOfScore);
      
        public bool SaveRestaurant(Restaurant restaurant);
        
        public bool UpdateRestaurant(Restaurant restaurant);
        
        public bool Delete(Restaurant restaurant);
       
    }
}
