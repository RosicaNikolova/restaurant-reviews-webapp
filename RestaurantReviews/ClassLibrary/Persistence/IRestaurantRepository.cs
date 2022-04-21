using ClassLibrary.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Persistence
{
    public interface IRestaurantRepository
    {

        public List<Restaurant> GetRestuarants();
        
        public Restaurant FindRestaurant(int id);
       
        public int GetNumberOfReviews(int id);
       
        public double GetScoreForRestaurant(int id, string typeOfScore);
      
        public void SaveRestaurant(Restaurant restaurant);
        
        public void UpdateRestaurant(Restaurant restaurant);
        
        public void Delete(Restaurant restaurant);
        public int GetRestuarantIdByName(string name);
        string GetRestaurantName(int restaurantId);
        List<Restaurant> GetAllRestaurantsEligibleForDiscount();
    }
}
