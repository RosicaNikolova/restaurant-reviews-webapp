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
            List<Restaurant> restaurants = restaurantRepository.GetRestuarants();

            foreach (Restaurant restaurant in restaurants)
            {
                restaurant.Food_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "food_score");
                restaurant.Service_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "service_score");
                restaurant.Price_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "athmosphere_score");
                restaurant.NumberOfReviews = restaurantRepository.GetNumberOfReviews(restaurant.Id);
            }

            return restaurants;

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

        public Restaurant GetRestaurant(int id)
        {
            Restaurant restaurant = restaurantRepository.FindRestaurant(id);
            restaurant.Food_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id,"food_score");
            restaurant.Service_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "service_score");
            restaurant.Price_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id,"athmosphere_score");
            restaurant.NumberOfReviews = restaurantRepository.GetNumberOfReviews(restaurant.Id);

            return restaurant;
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
