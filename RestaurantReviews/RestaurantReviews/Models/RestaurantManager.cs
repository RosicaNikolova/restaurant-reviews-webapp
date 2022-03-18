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

        public void CreateNewRestaurant(string name, string city, string street, string postcode, int streetNumber, string phone, string parking, string delivery)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Name = name;
            restaurant.City = city;
            restaurant.Street = street;
            restaurant.PostCode = postcode;
            restaurant.StreetNumber = streetNumber;
            restaurant.PhoneNumber = phone;
            restaurant.HasParking = parking;
            restaurant.HasDelivery = delivery;

            restaurantRepository.SaveRestaurant(restaurant);
        }

        public void UpdateRestaurantInfo(string name, string city, string street, string postcode, int streetNumber, string phone, string parking, string delivery, Restaurant restaurant)
        { 
            restaurant.Name = name;
            restaurant.City = city;
            restaurant.Street = street;
            restaurant.PostCode = postcode;
            restaurant.StreetNumber = streetNumber;
            restaurant.PhoneNumber = phone;
            restaurant.HasParking = parking;
            restaurant.HasDelivery = delivery;
            restaurantRepository.UpdateRestaurant(restaurant);
        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            restaurantRepository.Delete(restaurant);
        }
    }
}
