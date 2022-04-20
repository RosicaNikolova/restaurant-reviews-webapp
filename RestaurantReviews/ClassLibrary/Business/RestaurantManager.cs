using ClassLibrary.Exceptions;
using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Business
{
    public class RestaurantManager
    {
        IRestaurantRepository restaurantRepository;

        public RestaurantManager(IRestaurantRepository repository)
        {
            this.restaurantRepository = repository;
        }

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

        public Restaurant GetRestaurant(int id)
        {
            Restaurant restaurant = restaurantRepository.FindRestaurant(id);
            if (restaurant != null)
            {
                restaurant.Food_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "food_score");
                restaurant.Service_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "service_score");
                restaurant.Price_Score = restaurantRepository.GetScoreForRestaurant(restaurant.Id, "athmosphere_score");
                restaurant.NumberOfReviews = restaurantRepository.GetNumberOfReviews(restaurant.Id);
                return restaurant;
            }
            else
            {
                return null;
            }
        }

        public int GetIdByName(string restaurantName)
        {
            int id = restaurantRepository.GetRestuarantIdByName(restaurantName);
            return id;
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
            try
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
            catch (Exception)
            {
                throw new RestaurantInfoException();
            }
        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            restaurantRepository.Delete(restaurant);

        }

        public string GetRestaurantName(int restaurantId)
        {
            string restaurantName = restaurantRepository.GetRestaurantName(restaurantId);
            return restaurantName;
        }

        public List<Restaurant> FindAllRestaurantsEligibleForDiscount()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants = restaurantRepository.GetAllRestaurantsEligibleForDiscount();
            return restaurants;

        }
    }
}
