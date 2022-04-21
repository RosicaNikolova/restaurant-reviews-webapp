using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Business
{
    public interface IRestaurantManager
    {
        public List<Restaurant> GetAllRestaurants();
        public Restaurant GetRestaurant(int id);
        public int GetIdByName(string restaurantName);
        public void CreateNewRestaurant(string name, string city, string street, string postcode, int streetNumber, string phone, string parking, string delivery);
        public void UpdateRestaurantInfo(string name, string city, string street, string postcode, int streetNumber, string phone, string parking, string delivery, Restaurant restaurant);
        public void DeleteRestaurant(Restaurant restaurant);     
        public string GetRestaurantName(int restaurantId);
        public List<Restaurant> FindAllRestaurantsEligibleForDiscount();
       
    }
}
